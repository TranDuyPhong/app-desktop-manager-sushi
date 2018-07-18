using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSHUSHI.DATAPROVIDER;
using QUANLYSHUSHI.MODEL;
using System.Data;

namespace QUANLYSHUSHI.DAO
{
    public class GetData
    {
        private static volatile GetData _getdata;

        public static GetData Get
        {
            get
            {
                if (_getdata == null)
                {
                    _getdata = new GetData();
                }

                return _getdata;
            }
        }

        private GetData() { }

        public List<LoginSystem> Login()
        {
            List<LoginSystem> _list = new List<LoginSystem>();

            string _sQuery = "SELECT * FROM LOGINSYSTEM";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                LoginSystem _login = new LoginSystem();

                _login.ID = _dr["ID"].ToString();
                _login.Pass = _dr["PASS"].ToString();
                _login.Email = _dr["EMAIL"].ToString();

                _list.Add(_login);

                _login = null;
            }

            _dt = null;

            return _list;
        }

        public List<LoginSystem> LoginSystem()
        {
            List<LoginSystem> _loginSystem = new List<LoginSystem>();

            string _sQuery = "SELECT * FROM LOGINSYSTEM";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                LoginSystem _ls = new LoginSystem();

                _ls.ID = _dr["ID"].ToString();
                _ls.Pass = _dr["PASS"].ToString();
                _ls.Email = _dr["EMAIL"].ToString();

                _loginSystem.Add(_ls);

                _ls = null;
            }

            _dt = null;

            return _loginSystem;
        }

        public int ChangePassword(string _sUsername, string _sPass)
        {
            string _sQuery = "UPDATE LOGINSYSTEM SET PASS = @PASS WHERE ID = @ID";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _sPass, _sUsername });
        }

        public List<Food> Food()
        {
            List<Food> _listFood = new List<Food>();

            string _sQuery = "SELECT * FROM FOOD";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                Food _f = new Food();

                _f.ID = _dr["ID"].ToString();

                _f.Name = _dr["NAME"].ToString();

                _f.Price = (float)Convert.ToDouble(_dr["PRICE"].ToString());

                _listFood.Add(_f);

                _f = null;
            }

            _dt = null;

            return _listFood;
        }

        public List<Bill> Bill()
        {
            List<Bill> _listBIll = new List<Bill>();

            string _sQuery = "SELECT * FROM BILL";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                Bill _b = new Bill();

                _b.ID = _dr["ID"].ToString();

                _b.ThoiGianLap = _dr["THOIGIANLAP"].ToString();

                _b.ThoiGianXuat = _dr["THOIGIANXUAT"].ToString() == "" || _dr["THOIGIANXUAT"].ToString() == null ? "Chưa Thanh Toán" : _dr["THOIGIANXUAT"].ToString();

                _b.TongTien = (float)Convert.ToDouble(_dr["TONGTIEN"]);

                _b.IDBan = _dr["IDBAN"].ToString();

                _listBIll.Add(_b);

                _b = null;
            }

            _dt = null;

            return _listBIll;
        }

        public List<ChucVu> ChucVu()
        {
            List<ChucVu> _listChucVu = new List<ChucVu>();

            string _sQuery = "SELECT * FROM CHUCVU";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                ChucVu _cv = new ChucVu();

                _cv.ID = _dr["ID"].ToString();
                _cv.Name = _dr["NAME"].ToString();

                _listChucVu.Add(_cv);

                _cv = null;
            }

            _dt = null;

            return _listChucVu;
        }

        public List<NhanVien> NhanVien()
        {
            List<NhanVien> _listNhanVien = new List<NhanVien>();

            string _sQuery = "SELECT * FROM NHANVIEN";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                NhanVien _nv = new NhanVien();

                _nv.ID = _dr["ID"].ToString();

                _nv.Name = _dr["NAME"].ToString();

                _nv.Phone = _dr["PHONE"].ToString();

                _nv.Email = _dr["EMAIL"].ToString();

                _nv.Sex = (bool)_dr["SEX"];

                _nv.Brithday = _dr["BRITHDAY"].ToString();

                _nv.Luong = (float)Convert.ToDouble(_dr["LUONG"]);

                _nv.IDChucVu = _dr["IDCHUCVU"].ToString();

                _listNhanVien.Add(_nv);

                _nv = null;
            }

            _dt = null;

            return _listNhanVien;
        }

        public List<Ban> Ban()
        {
            List<Ban> _listBan = new List<Ban>();

            string _sQuery = "SELECT * FROM BAN";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                Ban _b = new Ban();

                _listBan.Add(_b);

                _b.ID = _dr["ID"].ToString();

                _b.Name = _dr["Name"].ToString();

                _b.TrangThai = _dr["TRANGTHAI"].ToString();

                _b = null;
            }

            _dt = null;

            return _listBan;
        }

        public int AddNhanVien(NhanVien _nv, LuongTam _lt)
        {
            string _sQuery = "INSERT INTO NHANVIEN VALUES ( dbo.FCTHEMNHANVIEN(), N'" + _nv.Name + "' , @PHONE , @EMAIL , @SEX , @BIRTHDAY , @LUONG , @IDCHUCVU )";

            string _sQuery1 = "INSERT INTO LUONGTAM VALUES ( dbo.FCTHEMLUONGTAM(), @LUONG )";

            int _i = 0;

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _nv.Phone, _nv.Email, _nv.Sex == true ? 1 : 0, _nv.Brithday, _nv.Luong, _nv.IDChucVu });

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _lt.Luong });

            _nv = null;

            _lt = null;

            return _i;
        }

        public int RemoveNhanVien(string _sId, NgayNghi _nn, DanhSachCa _dsc, CaNghi _cn, LuongTam _lt)
        {
            int _i = 0;

            string _sQuery = "DELETE NHANVIEN WHERE ID = @ID";

            string _sQuery1 = "DELETE NGAYNGHI WHERE IDNHANVIEN = @IDNHANVIEN";

            string _sQuery2 = "DELETE DANHSACHCA WHERE IDNHANVIEN = @IDNHANVIEN";

            string _sQuery3 = "DELETE CANGHI WHERE IDNHANVIEN = @IDNHANVIEN";

            string _sQuery4 = "DELETE LUONGTAM WHERE IDNHANVIEN = @IDNHANVIEN";

            if (_nn != null)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _nn.IDNhanVien });
            }

            if (_dsc != null)
            {
                 _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _dsc.IDNhanVien });
            }

            if(_cn != null)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery3, new object[] { _cn.IDNhanVien });
            }

            _i+= SelectData.Select.ExcuteNonQuery(_sQuery4, new object[]{ _lt.IDNhanVien });

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _sId }) + _i;
        }

        public int EditNhanVien(string _sId, NhanVien _nv, LuongTam _lt)
        {
            string _sQuery = "UPDATE NHANVIEN SET NAME = N'" + _nv.Name + "' , PHONE = @PHONE , EMAIL = @EMAIL , SEX = @SEX , BRITHDAY = @BIRTHDAY , LUONG = @LUONG , IDCHUCVU = @IDCHUCVU WHERE ID = @ID";

            string _sQuery1 = "UPDATE LUONGTAM SET LUONG = @LUONG WHERE IDNHANVIEN = @IDNHANVIEN";

            int _i = 0;

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _nv.Phone, _nv.Email, _nv.Sex == true ? 1 : 0, _nv.Brithday, _nv.Luong, _nv.IDChucVu, _sId });

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _lt.Luong, _lt.IDNhanVien });

            _nv = null;

            return _i;
        }

        public int AddMonAn(Food _f)
        {
            string _sQuery = "INSERT INTO FOOD VALUES ( dbo.FCTHEMMONAN() , N'" + _f.Name + "' , @PRICE )";

            int _i = SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _f.Price });

            _f = null;

            return _i;
        }

        public int RemoveMonAn(string _sId)
        {
            string _sQuery = "DELETE FOOD WHERE ID = @ID";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _sId });
        }

        public int EditMonAn(string _sId, Food _f)
        {
            string _sQuery = "UPDATE FOOD SET NAME = N'" + _f.Name + "' , PRICE = @PRICE WHERE ID = @ID";

            int _i = SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _f.Price, _sId });

            _f = null;

            return _i;
        }

        public List<BillFood> BillFood()
        {
            string _sQuery = "SELECT BF.IDBILL, BF.IDFOOD, BF.NAME, BF.PRICE, BF.SOLUONG, BF.THANHTIEN, BF.IDBAN FROM BILLFOOD AS BF INNER JOIN BILL AS B ON BF.IDBILL = B.ID";

            List<BillFood> _listBillFood = new List<BillFood>();

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach (DataRow _dr in _dt.Rows)
            {
                BillFood _bf = new BillFood();

                _bf.IDBill = _dr["IDBILL"].ToString();

                _bf.IDFood = _dr["IDFOOD"].ToString();

                _bf.NameFood = _dr["NAME"].ToString();

                _bf.Gia = (float)Convert.ToDouble(_dr["PRICE"]);

                _bf.SoLuong = Convert.ToByte(_dr["SOLUONG"].ToString());

                _bf.ThanhTien = (float)Convert.ToDouble(_dr["THANHTIEN"]);

                _bf.IDBan = _dr["IDBAN"].ToString();

                _listBillFood.Add(_bf);

                _bf = null;
            }

            _dt = null;

            return _listBillFood;
        }

        public int AddBill(Bill _b, List<BillFood> _listBillFood)
        {
            int _i = 0;

            string _sQuery = "INSERT INTO BILL VALUES ( dbo.FCMABILL() , @THOIGIANLAP , @THOIGIANXUAT , @TONGTIEN , @IDBAN )";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _b.ThoiGianLap, _b.ThoiGianXuat, _b.TongTien, _b.IDBan });

            string _sQuery1 = "EXEC SP_THEMBILLFOOD @IDFOOD , @NAME , @PRICE , @SOLUONG , @THANHTIEN , @IDBAN";

            foreach (BillFood _bf in _listBillFood)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _bf.IDFood, _bf.NameFood, _bf.Gia, _bf.SoLuong, _bf.ThanhTien, _bf.IDBan });
            }

            string _sQuery2 = "UPDATE BAN SET TRANGTHAI = N'Có người' WHERE ID = @ID";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _b.IDBan });

            return _i;
        }

        public int AddMonAnBill(List<BillFood> _listUpdate, List<BillFood> _listAdd, Bill _b)
        {
            int _i = 0;

            string _sQuery = "UPDATE BILLFOOD SET SOLUONG = @SOLUONG , THANHTIEN = @THANHTIEN WHERE IDBILL = @IDBILL AND IDFOOD = @IDFOOD AND IDBAN = @IDBAN";

            foreach (BillFood _bf in _listUpdate)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _bf.SoLuong, _bf.ThanhTien, _bf.IDBill, _bf.IDFood, _bf.IDBan });
            }

            string _sQuery1 = "INSERT INTO BILLFOOD VALUES ( @IDBILL , @IDFOOD , @NAME , @PRICE , @SOLUONG , @THANHTIEN , @IDBAN )";

            foreach (BillFood _bf in _listAdd)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _bf.IDBill, _bf.IDFood, _bf.NameFood, _bf.Gia, _bf.SoLuong, _bf.ThanhTien, _bf.IDBan });
            }

            string _sQuery2 = "UPDATE BILL SET TONGTIEN = @TONGTIEN WHERE ID = @ID";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _b.TongTien, _b.ID });

            return _i;
        }

        public int RemoveBillFood(List<BillFood> _listFood, Bill _billChange, Bill _b = null)
        {
            int _i = 0;

            string _sQuery = "DELETE BILLFOOD WHERE IDBILL = @IDBILL AND IDFOOD = @IDFOOD AND IDBAN = @IDBAN";
            string _sQuery1 = "UPDATE BILL SET TONGTIEN = @TONGTIEN WHERE ID = @ID";
           
            if(_b == null && _billChange != null)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _billChange.TongTien, _billChange.ID });
            }

            foreach (BillFood _bf in _listFood)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _bf.IDBill, _bf.IDFood, _bf.IDBan });
            }

            if (_b != null)
            {
                string _sQuery2 = "DELETE BILL WHERE ID = @ID";
                string _sQuery3 = "UPDATE BAN SET TRANGTHAI = N'Trống' WHERE ID = @ID";

                _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _b.ID });
                _i += SelectData.Select.ExcuteNonQuery(_sQuery3, new object[] { _b.IDBan });
            }

            return _i;
        }

        public int EditBillFood(BillFood _bf, Bill _b)
        {
            int _i = 0;

            string _sQuery = "UPDATE BILLFOOD SET SOLUONG = @SOLUONG , THANHTIEN = @THANHTIEN WHERE IDBILL = @IDBILL AND IDFOOD = @IDFOOD AND IDBAN = @IDBAN";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _bf.SoLuong, _bf.ThanhTien, _bf.IDBill, _bf.IDFood, _bf.IDBan });

            string _sQuery1 = "UPDATE BILL SET TONGTIEN = @TONGTIEN WHERE ID = @ID";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _b.TongTien, _b.ID });

            return _i;
        }

        public int ThanhToanBill(Bill _b, Ban _ban)
        {
            int _i = 0;

            string _sQuery = "UPDATE BILL SET THOIGIANXUAT = @THOIGIANXUAT WHERE ID = @ID AND IDBAN = @IDBAN AND THOIGIANXUAT = N'Chưa Thanh Toán'";

            string _sQuery1 = "UPDATE BAN SET TRANGTHAI = @TRANGTHAI WHERE ID = @ID ";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _b.ThoiGianXuat, _b.ID, _b.IDBan });

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _ban.TrangThai, _ban.ID });

            return _i;
        }

        public int AddUser(LoginSystem _ls)
        {
            string _sQuery = "INSERT INTO LOGINSYSTEM VALUES ( @ID , @PASS , @EMAIL )";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _ls.ID, _ls.Pass, _ls.Email });
        }

        public int ChuyenBan(Bill _b, List<BillFood> _listBilFood, List<Ban> _listBan)
        {
            int _i = 0;

            foreach(Ban _ban in _listBan)
            {
                _i+= SelectData.Select.ExcuteNonQuery("UPDATE BAN SET TRANGTHAI = N'" + _ban.TrangThai + "' WHERE ID = @ID", new object[]{ _ban.ID} );
            }

            string _sQuery = "UPDATE BILL SET IDBAN = @IDBAN WHERE ID = @ID AND THOIGIANXUAT = N'Chưa Thanh Toán'";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _b.IDBan, _b.ID });

            string _sQuery1 = "UPDATE BILLFOOD SET IDBAN = @IDBAN WHERE IDBILL = @IDBILL AND IDFOOD = @IDFOOD";

            foreach(BillFood _billFood in _listBilFood)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _billFood.IDBan, _billFood.IDBill, _billFood.IDFood });
            }

            return _i;
        }

        public int ThemChucVu(ChucVu _cv)
        {
            string _sQuery = "INSERT INTO CHUCVU VALUES ( dbo.FCTHEMCHUCVU() , N'" + _cv.Name + "' )";

            return SelectData.Select.ExcuteNonQuery(_sQuery);
        }

        public int SuaChucVu(ChucVu _cv, List<NhanVien> _listNhanVien)
        {
            int _i = 0;

            string _sQuery = "UPDATE CHUCVU SET NAME = @NAME WHERE ID = @ID";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _cv.Name, _cv.ID });

            string _sQuery1 = "UPDATE NHANVIEN SET IDCHUCVU = @IDCHUCVU WHERE ID = @ID";

            foreach(NhanVien _nv in _listNhanVien)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _nv.IDChucVu, _nv.ID });
            }

            return _i;
        }

        public int XoaChucVu(ChucVu _cv)
        {
            string _sQuery = "DELETE FROM CHUCVU WHERE ID = @ID";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _cv.ID });
        }

        public List<NgayNghi> NgayNghi()
        {
            List<NgayNghi> _listNgayNghi = new List<NgayNghi>();
;
            string _sQuery = "SELECT * FROM NGAYNGHI";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                NgayNghi _nn = new NgayNghi();

                _nn.Ngay = _dr["NGAYNGHI"].ToString();
                _nn.IDNhanVien = _dr["IDNHANVIEN"].ToString();

                _listNgayNghi.Add(_nn);

                _nn = null;
            }

            _dt = null;

            return _listNgayNghi;
        }

        public List<DanhSachCa> DanhSachCa()
        {
            List<DanhSachCa> _listDanhSachCa = new List<DanhSachCa>();

            string _sQuery = "SELECT * FROM DANHSACHCA";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                DanhSachCa _dsc = new DanhSachCa();

                _dsc.ID = _dr["ID"].ToString();
                _dsc.Thu = _dr["THU"].ToString();
                _dsc.GioLam = _dr["GIOLAM"].ToString();
                _dsc.GioKetThuc = _dr["GIOKETTHUC"].ToString();
                _dsc.CheckCa = (bool)_dr["CHECKCA"];
                _dsc.IDNhanVien = _dr["IDNHANVIEN"].ToString();

                _listDanhSachCa.Add(_dsc);

                _dsc = null;
            }

            return _listDanhSachCa;
        }

        public int DiemDanhNgay(DanhSachCa _dsc, NgayNghi _nn, bool _bCheckCa)
        {
            int _i = 0;

            string _sQuery = "UPDATE DANHSACHCA SET CHECKCA = @CHECKCA WHERE ID = @ID AND IDNHANVIEN = @IDNHANVIEN";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _dsc.CheckCa, _dsc.ID, _dsc.IDNhanVien });

            if(_bCheckCa == false)
            {
                string _sQuery1 = "INSERT INTO NGAYNGHI VALUES ( @NGAYNGHI , @IDNHANVIEN )";

                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _nn.Ngay, _nn.IDNhanVien });
            }

            if(_bCheckCa == true)
            {
                string _sQuery2 = "DELETE NGAYNGHI WHERE IDNHANVIEN = @IDNHANVIEN";

                _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _nn.IDNhanVien });
            }

            return _i;
        }

        public int ThemCa(DanhSachCa _dsc)
        {
            string _sQuery = "INSERT INTO DANHSACHCA VALUES ( dbo.FCTHEMCA() , @THU , @GIOLAM , @GIOKETTHUC , @CHECKCA , @IDNHANVIEN )";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _dsc.Thu, _dsc.GioLam, _dsc.GioKetThuc, _dsc.CheckCa, _dsc.IDNhanVien });
        }

        public List<CaNghi> CaNghi()
        {
            List<CaNghi> _listCaNghi = new List<CaNghi>();

            string _sQuery = "SELECT * FROM CANGHI";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                CaNghi _cn = new CaNghi();

                _cn.NgayNghi = _dr["NGAYNGHICA"].ToString();
                _cn.GioLam = _dr["GIOLAM"].ToString();
                _cn.IDNhanVien = _dr["IDNHANVIEN"].ToString();

                _listCaNghi.Add(_cn);

                _cn = null;
            }

            _dt = null;

            return _listCaNghi;
        }

        public int DiemDanhCa(DanhSachCa _dsc,CaNghi _cn, bool _bCheckCa)
        {
            string _sQuery = "INSERT INTO CANGHI VALUES ( @NGAYNGHICA , @GIOLAM , @IDNHANVIEN )";

            string _sQuery1 = "DELETE CANGHI WHERE NGAYNGHICA = @NGAYNGHICA AND GIOLAM = @GIOLAM AND IDNHANVIEN = @IDNHANVIEN";

            string _sQuery2 = "UPDATE DANHSACHCA SET CHECKCA = @CHECKCA WHERE IDNHANVIEN = @IDNHANVIEN AND ID = @ID";

            int _i = 0;

            _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _dsc.CheckCa, _dsc.IDNhanVien, _dsc.ID });

            if(_bCheckCa == false)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _cn.NgayNghi, _cn.GioLam, _cn.IDNhanVien });
            }

            if(_bCheckCa == true)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _cn.NgayNghi, _cn.GioLam, _cn.IDNhanVien });
            }

            return _i;
        }

        public int ChuyenCaThanhNgay(CaNghi _cn, NgayNghi _nn, DanhSachCa _dsc)
        {
            int _i = 0;

            string _sQuery = "INSERT INTO NGAYNGHI VALUES ( @NGAYNGHI , @IDNHANVIEN )";

            string _sQuery1 = "DELETE CANGHI WHERE IDNHANVIEN = @IDNHANVIEN AND NGAYNGHICA = @NGAYNGHICA";

            string _sQuery2 = "UPDATE DANHSACHCA SET CHECKCA = @CHECKCA WHERE ID = @ID AND IDNHANVIEN = @IDNHANVIEN";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _dsc.CheckCa, _dsc.ID, _dsc.IDNhanVien });

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _cn.IDNhanVien, _cn.NgayNghi});

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _nn.Ngay, _nn.IDNhanVien });

            return _i;
        }

        public int RefeshChuyenNgayThanhCa(DanhSachCa _dsc, NgayNghi _nn, List<CaNghi> _listCaNghi)
        {
            int _i = 0;

            string _sQuery = "UPDATE DANHSACHCA SET CHECKCA = @CHECKCA WHERE ID = @ID AND IDNHANVIEN = @IDNHANVIEN";

            string _sQuery1 = "DELETE NGAYNGHI WHERE NGAYNGHI = @NGAYNGHI AND IDNHANVIEN = @IDNHANVIEN";

            string _sQuery2 = "INSERT INTO CANGHI VALUES ( @NGAYNGHICA , @GIOLAM , @IDNHANVIEN )";

            _i += SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _dsc.CheckCa, _dsc.ID, _dsc.IDNhanVien });

            _i += SelectData.Select.ExcuteNonQuery(_sQuery1, new object[] { _nn.Ngay, _nn.IDNhanVien });

            foreach(CaNghi _cn in _listCaNghi)
            {
                _i += SelectData.Select.ExcuteNonQuery(_sQuery2, new object[] { _cn.NgayNghi, _cn.GioLam, _cn.IDNhanVien });
            }

            return _i;
        }

        public int RemoveCa(DanhSachCa _dsc)
        {
            string _sQuery = "DELETE DANHSACHCA WHERE ID = @ID AND IDNHANVIEN = @IDNHANVIEN";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _dsc.ID, _dsc.IDNhanVien });
        }

        public int EditCa(DanhSachCa _dsc)
        {
            string _sQuery = "UPDATE DANHSACHCA SET GIOLAM = @GIOLAM , GIOKETTHUC = @GIOKETTHUC , CHECKCA = @CHECKCA , IDNHANVIEN = @IDNHANVIEN WHERE ID = @ID";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _dsc.GioLam, _dsc.GioKetThuc, _dsc.CheckCa, _dsc.IDNhanVien, _dsc.ID, });
        }

        public int UpdateLuongTam(LuongTam _lt)
        {
            string _sQuery = "UPDATE LUONGTAM SET LUONG = @LUONG WHERE IDNHANVIEN = @IDNHANVIEN";

            return SelectData.Select.ExcuteNonQuery(_sQuery, new object[] { _lt.Luong, _lt.IDNhanVien });
        }

        public List<LuongTam> LuongTam()
        {
            List<LuongTam> _listLuongTam = new List<LuongTam>();

            string _sQuery = "SELECT * FROM LUONGTAM";

            DataTable _dt = SelectData.Select.ExcuteQuery(_sQuery);

            foreach(DataRow _dr in _dt.Rows)
            {
                LuongTam _lt = new LuongTam();

                _lt.IDNhanVien = _dr["IDNHANVIEN"].ToString();
                _lt.Luong = Convert.ToSingle(_dr["LUONG"]);
                _listLuongTam.Add(_lt);

                _lt = null;
            }

            _dt = null;

            return _listLuongTam;
        }
    }
}

