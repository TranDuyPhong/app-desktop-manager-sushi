using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYSHUSHI.DAO;
using QUANLYSHUSHI.MODEL;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI.BLL
{
    public class Transfer
    {
        private static fSystem _f;

        public static fSystem System
        {
            get
            {
                return _f;
            }
            set
            {
                _f = value;
            }
        }

        private static volatile Transfer _transfer;

        public static Transfer Trans
        {
            get
            {
                if (_transfer == null)
                {
                    _transfer = new Transfer();
                }

                return _transfer;
            }
        }

        private Transfer() { }

        private string _sMaBanTranfer = "";

        public bool CheckLogin(string _sId, string _sPass)
        {
            return (from c in GetData.Get.Login() where c.ID.CompareTo(_sId) == 0 && c.Pass.CompareTo(_sPass) == 0 select c).Count() > 0 ? true : false;
        }

        public bool ChangePassword(string _sUsername, string _sPass)
        {
            return GetData.Get.ChangePassword(_sUsername, _sPass) >= 1 ? true : false;
        }

        public bool GetPassWord(string _sUsername, string _sEmail)
        {
            LoginSystem _loginSystem = (from c in GetData.Get.LoginSystem()
                         where c.ID.Equals(_sUsername) == true
                         where c.Email.Equals(_sEmail) == true
                         select c).ToList()[0];

            if(_loginSystem == null)
            {
                return false;
            }

            Transfer.Trans.ChangePassword(_loginSystem.ID, GraphicsUserInterface.GraphicsUsers.MaHoa(ForgetPassword.Password));

            GraphicsUserInterface.GraphicsUsers.SendMail("Lấy Lại Mật Khẩu", "Mật Khẩu Của Bạn Là" + "\n" + ForgetPassword.Password, _loginSystem.Email);

            return true;
        }

        public void Food(GridControl _gc)
        {
            _gc.DataSource = null;

            _gc.DataSource = (from c in GetData.Get.Food() select new { c.ID, c.Name, c.Price }).ToList();
        }

        public void Bill(GridControl _gc)
        {
            _gc.DataSource = null;

            _gc.DataSource = (from c in GetData.Get.Bill()
                              join d in GetData.Get.Ban() on c.IDBan equals d.ID
                              select new { ID = c.ID, ThoiGianLap = c.ThoiGianLap, ThoiGianXuat = c.ThoiGianXuat, TenBan = d.Name, TongTien = c.TongTien }
                                  ).ToList();
        }

        public void ChucVuComboBox(System.Windows.Forms.ComboBox _cbb)
        {
            _cbb.DataSource = null;

            _cbb.DataSource = GetData.Get.ChucVu();
            _cbb.DisplayMember = "Name";
            _cbb.ValueMember = "ID";
        }

        public void ChucVu(GridControl _gc)
        {
            List<ChucVu> _listChucVu = GetData.Get.ChucVu();
            List<NhanVien> _listNhanVien = GetData.Get.NhanVien();

            _gc.DataSource = null;

            foreach (ChucVu _cv in _listChucVu)
            {
                foreach (NhanVien _nv in _listNhanVien)
                {
                    if (_cv.ID.Equals(_nv.IDChucVu) == true)
                    {
                        _cv.SoLuong += 1;
                    }
                }
            }

            _gc.DataSource = _listChucVu;

            _listChucVu = null;

            _listNhanVien = null;
        }

        public bool CheckBan(string _sId)
        {
            return (GetData.Get.Ban().Where(p => p.ID.CompareTo(_sId) == 0).Select(p => p.TrangThai)).ToList()[0].CompareTo("Có người") == 0 ? true : false;
        }

        public void SortBan(string _s, Panel _pn, List<SimpleButton> _listButton)
        {
            List<SimpleButton> _listButtonSort = new List<SimpleButton>();

            foreach (Control _c in _listButton)
            {
                if (_c.Text.EndsWith(_s) == true)
                {
                    _listButtonSort.Add(_c as SimpleButton);
                }
            }

            int _iLeft = 30;
            int _iTop = 20;
            int _i = 0;

            _pn.Controls.Clear();

            for (int _k = 0; _k < _listButtonSort.Count(); _k++)
            {
                _listButtonSort[_k].Left = _iLeft;

                _listButtonSort[_k].Top = _iTop;

                _iLeft += _listButtonSort[_k].Width + 25;

                _i++;

                if (_i == 4)
                {
                    _i = 0;

                    _iLeft = 30;

                    _iTop += _listButtonSort[_k].Height + 20;
                }

                _pn.Controls.Add(_listButtonSort[_k]);
            }

            _listButtonSort = null;

            _listButton = null;
        }

        public List<SimpleButton> Ban(Panel _pn, Bitmap _bmTrong, Bitmap _bmCoNguoi, LookUpEdit _cbb)
        {
            List<Ban> _listBan = GetData.Get.Ban();

            List<SimpleButton> _listButton = new List<SimpleButton>();

            _pn.Controls.Clear();

            _cbb.Properties.DataSource = null;
            _cbb.Properties.DataSource = _listBan;
            _cbb.Properties.DisplayMember = "Name";
            _cbb.Properties.ValueMember = "ID";

            int _iLeft = 30;
            int _iTop = 20;
            int _i = 0;

            ToolStripMenuItem _menu1 = new ToolStripMenuItem() { Text = "Thanh Toán" };
            ToolStripMenuItem _menu2 = new ToolStripMenuItem() { Text = "Chuyển Bàn" };
            _menu1.Click += _menu1_Click;
            _menu2.Click += _menu2_Click;
            ContextMenuStrip _cms = new ContextMenuStrip();
            _cms.Items.Add(_menu1);
            _cms.Items.Add(_menu2);

            foreach (Ban _b in _listBan)
            {
                SimpleButton _bt = new SimpleButton();

                _bt.ForeColor = Color.Black;

                _bt.Text = _b.Name + "\n" + _b.TrangThai;

                _bt.BorderStyle = BorderStyles.Office2003;

                if (_b.TrangThai.Equals("Có người") == true)
                {
                    _bt.Appearance.BackColor = Color.Gray;
                    _bt.Appearance.BackColor2 = Color.Gray;
                    _bt.Appearance.BorderColor = Color.Gray;

                    _bt.Image = _bmCoNguoi;
                }
                else
                {
                    _bt.Appearance.BackColor = Color.FromArgb(255, 192, 255);
                    _bt.Appearance.BackColor2 = Color.FromArgb(255, 192, 255);
                    _bt.Appearance.BorderColor = Color.FromArgb(255, 192, 255);

                    _bt.Image = _bmTrong;
                }

                _bt.AppearanceHovered.BackColor = Color.White;
                _bt.AppearanceHovered.BackColor2 = Color.White;
                _bt.AppearanceHovered.BorderColor = Color.White;

                _bt.AppearancePressed.BackColor = Color.FromArgb(192, 64, 0);
                _bt.AppearancePressed.BackColor2 = Color.FromArgb(192, 64, 0);
                _bt.AppearancePressed.BorderColor = Color.FromArgb(192, 64, 0);

                _bt.TabStop = false;

                _bt.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;

                _bt.Tag = _b.ID;

                _bt.Size = new Size(79, 62);

                _bt.Left = _iLeft;

                _iLeft += _bt.Size.Width + 25;

                _bt.Top = _iTop;

                _i++;

                if (_i == 4)
                {
                    _i = 0;
                    _iLeft = 30;
                    _iTop += _bt.Size.Height + 20;
                }

                _bt.ContextMenuStrip = _cms;

                _bt.Click += _bt_Click;

                _bt.MouseHover += _bt_MouseHover;

                _listButton.Add(_bt);

                _pn.Controls.Add(_bt);
            }

            return _listButton;
        }

        void _menu2_Click(object sender, EventArgs e)
        {
            int _i = Transfer.Trans.ChuyenBan(_f._sMaBan, _sMaBanTranfer);

            if (_i == 5)
            {
                XtraMessageBox.Show("Chuyển Bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.BillFood(_f._sMaBan, _f.dgvThucDonTheoBan);

                Transfer.Trans.Ban(_f.pnBan, Properties.Resources.Table3, Properties.Resources.Table4, _f.cbbBan);
            }
            else if (_i == 0)
            {
                XtraMessageBox.Show("Chưa chọn Bàn cần chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_i == 1)
            {
                XtraMessageBox.Show("Chưa chọn Bàn chuyển đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_i == 2)
            {
                return;
            }
            else if (_i == 3)
            {
                XtraMessageBox.Show("Bàn cần chuyển hiện tại không có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_i == 4)
            {
                XtraMessageBox.Show("Bàn chuyển đến hiện tại đã có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _bt_MouseHover(object sender, EventArgs e)
        {
            _sMaBanTranfer = "";

            _sMaBanTranfer = (sender as SimpleButton).Tag.ToString();
        }

        void _menu1_Click(object sender, EventArgs e)
        {
            float _float = ThanhToan(_sMaBanTranfer, _f.dgvThucDonTheoBan);

            if (_float != 1f && _float != 0f)
            {
                XtraMessageBox.Show("Bill đã thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.Ban(_f.pnBan, Properties.Resources.Table3, Properties.Resources.Table4, _f.cbbBan);
            }
            else if (_float == 1f)
            {
                XtraMessageBox.Show("Chưa chọn Bàn để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_float == 0f)
            {
                XtraMessageBox.Show("Bàn này không có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _sMaBanTranfer = "";
        }

        void _bt_Click(object sender, EventArgs e)
        {
            _f._sMaBan = (sender as SimpleButton).Tag.ToString();

            if ((sender as SimpleButton).Text.Contains("Có người") == true)
            {
                BillFood((sender as SimpleButton).Tag.ToString(), _f.dgvThucDonTheoBan);
            }
            else
            {
                _f.dgvThucDonTheoBan.Rows.Clear();
            }
        }

        private int ChuyenBan(string _sMaBanCanChuyen, string _sMaBanChuyenDen)
        {
            if (_sMaBanCanChuyen.Equals(string.Empty) == true)
            {
                return 0;
            }

            if (_sMaBanChuyenDen.Equals(string.Empty) == true)
            {
                return 1;
            }

            if (_sMaBanCanChuyen.Equals(_sMaBanChuyenDen) == true)
            {
                return 2;
            }

            if (Transfer.Trans.CheckBan(_sMaBanCanChuyen) == false)
            {
                return 3;
            }

            if (Transfer.Trans.CheckBan(_sMaBanChuyenDen) == true)
            {
                return 4;
            }

            Bill _bill = (from c in GetData.Get.Bill()
                          from d in GetData.Get.Ban()
                          where d.TrangThai.CompareTo("Có người") == 0
                          where c.IDBan.CompareTo(_sMaBanCanChuyen) == 0
                          where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                          select c).ToList()[0];

            List<BillFood> _listBillFood = (from c in GetData.Get.BillFood()
                                            where c.IDBill.CompareTo(_bill.ID) == 0
                                            where c.IDBan.CompareTo(_sMaBanCanChuyen) == 0
                                            select c).ToList();

            List<Ban> _listBan = new List<Ban>();
            Ban _banCanChuyen = new Ban() { ID = _sMaBanCanChuyen, TrangThai = "Trống" };
            Ban _banChuyenDen = new Ban() { ID = _sMaBanChuyenDen, TrangThai = "Có người" };
            _listBan.Add(_banCanChuyen);
            _listBan.Add(_banChuyenDen);

            _bill.IDBan = _sMaBanChuyenDen;

            foreach (BillFood _billFood in _listBillFood)
            {
                _billFood.IDBan = _sMaBanChuyenDen;
            }

            return GetData.Get.ChuyenBan(_bill, _listBillFood, _listBan) >= _listBillFood.Count + _listBan.Count + 1 ? 5 : 6;
        }

        public void BillFood(string _sId, DataGridView _dgv)
        {
            _dgv.Rows.Clear();

            bool _b = (from c in GetData.Get.Ban()
                       where c.ID.CompareTo(_sId) == 0
                       select c.TrangThai).ToList()[0].CompareTo("Có người") == 0 ? true : false;

            if (_b == true)
            {
                string _sMaBil = (from c in GetData.Get.Bill()
                                  where c.IDBan.CompareTo(_sId) == 0
                                  where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                                  select c.ID).ToList()[0];

                List<BillFood> _listBillFood = (from c in GetData.Get.BillFood()
                                                where c.IDBan.CompareTo(_sId) == 0
                                                where c.IDBill.CompareTo(_sMaBil) == 0
                                                select c).ToList();

                if (_listBillFood.Count > 0)
                {
                    int _i = 0;

                    foreach (BillFood _bf in _listBillFood)
                    {
                        _dgv.Rows.Add();

                        _dgv["IDBill", _i].Value = _bf.IDBill;
                        _dgv["IDFood", _i].Value = _bf.IDFood;
                        _dgv["TenThucAn", _i].Value = _bf.NameFood;
                        _dgv["Gia", _i].Value = _bf.Gia;
                        _dgv["SL", _i].Value = _bf.SoLuong;
                        _dgv["ThanhTien", _i].Value = _bf.ThanhTien;
                        _dgv["IDBan", _i].Value = _bf.IDBan;

                        _i++;
                    }
                }
            }
        }

        public void NhanVien(GridControl _gc)
        {
            _gc.DataSource = null;

            List<NgayNghi> _listNgayNghi = GetData.Get.NgayNghi();
            List<CaNghi> _listCaNghi = GetData.Get.CaNghi();

            _gc.DataSource = (from c in GetData.Get.NhanVien()
                              from d in GetData.Get.ChucVu()
                              where c.IDChucVu.Equals(d.ID) == true
                              select new
                              {
                                  ID = c.ID,
                                  Name = c.Name,
                                  Phone = c.Phone,
                                  Email = c.Email,
                                  Sex = c.Sex,
                                  Brithday = c.Brithday,
                                  Luong = c.Luong,
                                  TenChucVu = d.Name,
                                  SoNgayNghi = (from p in _listNgayNghi
                                                where p.IDNhanVien.Equals(c.ID) == true
                                                select p).Count() > 0 ? (from p in _listNgayNghi
                                                                         where p.IDNhanVien.Equals(c.ID) == true
                                                                         group p by p.IDNhanVien into newSoLuong
                                                                         select newSoLuong.Count()).ToList()[0] : 0,
                                  CaNghi = (from k in _listCaNghi
                                            where k.IDNhanVien.Equals(c.ID) == true
                                            select k).Count() > 0 ? (from k in _listCaNghi where k.IDNhanVien.Equals(c.ID) == true group k by k.IDNhanVien into newCa select newCa.Count()).ToList()[0] : 0
                              }).ToList();
        }

        public bool AddNhanVien(string _sName, string _sPhone, string _sEmail, bool _bSex, string _sBrithday, float _sLuong, string _sChucVu)
        {
            NhanVien _nv = new NhanVien() { Name = _sName, Phone = _sPhone, Email = _sEmail, Sex = _bSex, Brithday = _sBrithday, Luong = _sLuong, IDChucVu = _sChucVu };

            LuongTam _lt = new LuongTam() { Luong = _sLuong };

            bool _b = GetData.Get.AddNhanVien(_nv, _lt) >= 2 ? true : false;

            _nv = null;

            return _b;
        }

        public bool RemoveNhanVien(string _sId)
        {
            List<NgayNghi> _listNgayNghi = GetData.Get.NgayNghi();

            NgayNghi _nn = (from c in _listNgayNghi where c.IDNhanVien.Equals(_sId) == true select c).ToList().Count() > 0 ? (from c in _listNgayNghi where c.IDNhanVien.Equals(_sId) == true select c).ToList()[0] : null;

            List<CaNghi> _listCaNghi = GetData.Get.CaNghi();

            CaNghi _cn = (from c in _listCaNghi where c.IDNhanVien.Equals(_sId) == true select c).ToList().Count() > 0 ? (from c in _listCaNghi where c.IDNhanVien.Equals(_sId) == true select c).ToList()[0] : null;

            List<DanhSachCa> _listDanhSachCa = GetData.Get.DanhSachCa();

            DanhSachCa _dsc = (from c in _listDanhSachCa where c.IDNhanVien.Equals(_sId) == true select c).ToList().Count() > 0 ? (from c in _listDanhSachCa where c.IDNhanVien.Equals(_sId) == true select c).ToList()[0] : null;

            List<LuongTam> _listLuongTam = GetData.Get.LuongTam();

            LuongTam _lt = (from c in _listLuongTam where c.IDNhanVien.Equals(_sId) == true select c).ToList()[0];

            return GetData.Get.RemoveNhanVien(_sId, _nn, _dsc, _cn, _lt) >= (_nn == null ? 0 : 1) + (_cn == null ? 0 : 1) + (_dsc == null ? 0 : 1) + 2 ? true : false;
        }

        public bool EditNhanVien(string _sId, string _sName, string _sPhone, string _Email, bool _bSex, string _sBirthday, float _fLuong, string _sChucVu)
        {
            NhanVien _nv = new NhanVien() { Name = _sName, Phone = _sPhone, Email = _Email, Sex = _bSex, Brithday = _sBirthday, Luong = _fLuong, IDChucVu = _sChucVu };

            LuongTam _lt = (from c in GetData.Get.LuongTam()
                            where c.IDNhanVien.Equals(_sId) == true
                            select c).ToList()[0];

            _lt.Luong = _fLuong;

            bool _b = GetData.Get.EditNhanVien(_sId, _nv, _lt) >= 2 ? true : false;

            _nv = null;

            return _b;
        }

        public bool AddFood(string _sName, float _sPrice)
        {
            Food _f = new Food() { Name = _sName, Price = _sPrice };

            bool _b = GetData.Get.AddMonAn(_f) >= 1 ? true : false;

            _f = null;

            return _b;
        }

        public bool EditFood(string _sId, string _sName, float _sPrice)
        {
            Food _f = new Food() { Name = _sName, Price = _sPrice };

            bool _b = GetData.Get.EditMonAn(_sId, _f) >= 1 ? true : false;

            _f = null;

            return _b;
        }

        public bool RemoveFood(string _sIDMonAn)
        {
            List<string> _listBill = (from c in GetData.Get.Bill()
                                      where c.ThoiGianXuat.Equals("Chưa Thanh Toán") == true
                                      select c.ID).ToList();

            bool _bCheckFood = (from c in GetData.Get.BillFood()
                                from d in _listBill
                                where c.IDBill.Equals(d) == true
                                where c.IDFood.Equals(_sIDMonAn) == true
                                select c).Count() > 0 ? true : false;

            if(_bCheckFood == true)
            {
                return false;
            }

            return GetData.Get.RemoveMonAn(_sIDMonAn) >= 1 ? true : false;
        }

        public bool AddBill(Bill _b, List<BillFood> _listBillFood)
        {
            for (int _i = 0; _i < _listBillFood.Count(); _i++)
            {
                for (int _j = 0; _j < _listBillFood.Count(); _j++)
                {
                    if (_j < _listBillFood.Count() - 1)
                    {
                        if (_listBillFood[_j].IDFood.CompareTo(_listBillFood[_j + 1].IDFood) == 1)
                        {
                            BillFood _bf = _listBillFood[_j];

                            _listBillFood[_j] = _listBillFood[_j + 1];

                            _listBillFood[_j + 1] = _bf;
                        }
                    }
                }
            }

            float _iTongTien = 0;

            foreach (BillFood _bf in _listBillFood)
            {
                var _float = from c in GetData.Get.Food() where c.ID.CompareTo(_bf.IDFood) == 0 select c.Price;

                _bf.ThanhTien = _bf.SoLuong * _float.ToList()[0];

                _iTongTien += _bf.ThanhTien;
            }

            _b.TongTien = _iTongTien;
            _b.ThoiGianLap = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            _b.ThoiGianXuat = "Chưa Thanh Toán";

            return GetData.Get.AddBill(_b, _listBillFood) >= _listBillFood.Count() + 2 ? true : false;
        }

        public bool AddMonAnBill(DataGridView _dgv, string _sMaBan, DataGridView _dgv1)
        {
            List<BillFood> _listBillFood = new List<BillFood>();

            Bill _bill = (from c in GetData.Get.Bill()
                          where c.ID.CompareTo(_dgv1["IDBill", 0].Value.ToString()) == 0
                          where c.IDBan.CompareTo(_sMaBan) == 0
                          where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                          select c).ToList()[0];

            for (int _i = 0; _i < _dgv.SelectedRows.Count; _i++)
            {
                BillFood _bf = new BillFood();

                _bf.IDBill = _bill.ID;
                _bf.IDFood = _dgv.SelectedRows[_i].Cells["ID"].Value.ToString();
                _bf.NameFood = _dgv.SelectedRows[_i].Cells["Name"].Value.ToString();
                _bf.Gia = (float)Convert.ToDouble(_dgv.SelectedRows[_i].Cells["Price"].Value.ToString());
                _bf.SoLuong = Convert.ToByte(_dgv.SelectedRows[_i].Cells["SoLuong"].Value.ToString());
                _bf.IDBan = _sMaBan;

                _listBillFood.Add(_bf);
            }

            List<BillFood> _listUpdate = new List<BillFood>();

            List<BillFood> _listAdd = new List<BillFood>();

            float _fTongTien = _bill.TongTien;

            foreach (BillFood _bf in _listBillFood)
            {
                var _item = from c in GetData.Get.BillFood()
                            where c.IDFood.CompareTo(_bf.IDFood) == 0
                            where c.IDBan.CompareTo(_bf.IDBan) == 0
                            where c.IDBill.CompareTo(_bill.ID) == 0
                            select c.SoLuong;

                if (_item.ToList().Count() <= 0)
                {
                    _bf.ThanhTien = _bf.SoLuong * _bf.Gia;

                    _fTongTien += _bf.ThanhTien;

                    _listAdd.Add(_bf);
                }
                if (_item.ToList().Count() > 0)
                {
                    _bf.SoLuong = Convert.ToByte(_bf.SoLuong + _item.ToList()[0]);

                    var _itemThanhTienBanDau = from c in GetData.Get.BillFood()
                                               where c.IDFood.CompareTo(_bf.IDFood) == 0
                                               where c.IDBan.CompareTo(_bf.IDBan) == 0
                                               where c.IDBill.CompareTo(_bill.ID) == 0
                                               select c.ThanhTien;

                    _fTongTien -= _itemThanhTienBanDau.ToList()[0];

                    _bf.ThanhTien = _bf.SoLuong * _bf.Gia;

                    _fTongTien += _bf.ThanhTien;

                    _listUpdate.Add(_bf);
                }
            }

            _bill.TongTien = _fTongTien;

            return GetData.Get.AddMonAnBill(_listUpdate, _listAdd, _bill) >= _listAdd.Count() + _listBillFood.Count() ? true : false;
        }

        public bool RemoveBillFoood(DataGridView _dgv)
        {
            int _j = 0;

            Bill _b = null;

            Bill _billChange = (from c in GetData.Get.Bill()
                                where c.ID.CompareTo(_dgv.SelectedRows[0].Cells["IDBill"].Value.ToString()) == 0
                                where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                                where c.IDBan.CompareTo(_dgv.SelectedRows[0].Cells["IDBan"].Value.ToString()) == 0
                                select c).ToList()[0];

            float _fTongTien = _billChange.TongTien;

            List<BillFood> _listBillFood = new List<BillFood>();

            for (int _i = 0; _i < _dgv.SelectedRows.Count; _i++)
            {
                BillFood _bf = new BillFood();

                _bf.IDBill = _dgv.SelectedRows[_i].Cells["IDBill"].Value.ToString();
                _bf.IDFood = _dgv.SelectedRows[_i].Cells["IDFood"].Value.ToString();
                _bf.IDBan = _dgv.SelectedRows[_i].Cells["IDBan"].Value.ToString();
                _bf.ThanhTien = Convert.ToSingle(_dgv.SelectedRows[_i].Cells["ThanhTien"].Value.ToString());

                _fTongTien -= _bf.ThanhTien;

                _listBillFood.Add(_bf);

                _bf = null;
            }

            if (_dgv.SelectedRows.Count == _dgv.Rows.Count - 1)
            {
                _b = new Bill();

                _b.ID = _listBillFood[0].IDBill;
                _b.IDBan = _listBillFood[0].IDBan;

                _j += GetData.Get.RemoveBillFood(_listBillFood, _billChange, _b);

                _b = null;
            }
            else
            {
                _billChange.TongTien = _fTongTien;

                _j += GetData.Get.RemoveBillFood(_listBillFood, _billChange);
            }

            _billChange = null;

            _b = null;

            return _j >= _listBillFood.Count() ? true : false;
        }

        public bool EditBillFood(DataGridView _dgv, string _sSoLuong)
        {
            BillFood _bf = new BillFood();

            byte _bSoLuongLucSau = Convert.ToByte(_sSoLuong);

            float _fGia = 0f;

            float _fThanhTienBanDau = 0f;

            if (_dgv.CurrentRow.Selected)
            {
                _fGia = Convert.ToSingle(_dgv.SelectedRows[0].Cells["Gia"].Value.ToString());

                _fThanhTienBanDau = Convert.ToSingle(_dgv.SelectedRows[0].Cells["ThanhTien"].Value.ToString());

                _bf.IDBill = _dgv.SelectedRows[0].Cells["IDBill"].Value.ToString();
                _bf.IDFood = _dgv.SelectedRows[0].Cells["IDFood"].Value.ToString();
                _bf.IDBan = _dgv.SelectedRows[0].Cells["IDBan"].Value.ToString();
            }

            if (_dgv.CurrentCell.Selected)
            {

                _fGia = Convert.ToSingle(_dgv.SelectedCells[0].OwningRow.Cells["Gia"].Value.ToString());

                _fThanhTienBanDau = Convert.ToSingle(_dgv.SelectedCells[0].OwningRow.Cells["ThanhTien"].Value.ToString());

                _bf.IDBill = _dgv.SelectedCells[0].OwningRow.Cells["IDBill"].Value.ToString();
                _bf.IDFood = _dgv.SelectedCells[0].OwningRow.Cells["IDFood"].Value.ToString();
                _bf.IDBan = _dgv.SelectedCells[0].OwningRow.Cells["IDBan"].Value.ToString();
            }

            _bf.SoLuong = _bSoLuongLucSau;
            _bf.ThanhTien = _fGia * _bf.SoLuong;

            Bill _f = (from c in GetData.Get.Bill()
                       where c.ID.CompareTo(_bf.IDBill) == 0
                       where c.IDBan.CompareTo(_bf.IDBan) == 0
                       select c).ToList()[0];

            _f.TongTien = (_f.TongTien - _fThanhTienBanDau) + _bf.ThanhTien;

            return GetData.Get.EditBillFood(_bf, _f) >= 2 ? true : false;
        }

        public float ThanhToan(string _sMaBan, DataGridView _dgv)
        {
            Bill _b = new Bill();

            Ban _ban = new Ban();

            if (_sMaBan.Equals(string.Empty) == false)
            {
                if (Transfer.Trans.CheckBan(_sMaBan) == true)
                {
                    _b.ID = (from c in GetData.Get.Bill()
                             where c.IDBan.CompareTo(_sMaBan) == 0
                             where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                             select c.ID).ToList()[0];
                    _b.IDBan = _sMaBan;
                    _b.TongTien = (from c in GetData.Get.Bill()
                                   where c.IDBan.CompareTo(_sMaBan) == 0
                                   where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                                   select c.TongTien).ToList()[0];
                    _b.ThoiGianXuat = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

                    _ban.ID = _sMaBan;
                    _ban.TrangThai = "Trống";

                    GetData.Get.ThanhToanBill(_b, _ban);

                    _dgv.Rows.Clear();

                    return _b.TongTien;
                }
                else
                {
                    return 0f;
                }
            }
            else
            {
                return 1f;
            }
        }

        public void BillSort(string _s, GridControl _gc)
        {
            _gc.DataSource = null;

            if (_s.Equals("Chưa Thanh Toán") == true)
            {
                _gc.DataSource = from c in GetData.Get.Bill()
                                 where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") == 0
                                 from d in GetData.Get.Ban()
                                 where c.IDBan.CompareTo(d.ID) == 0
                                 select new { ID = c.ID, ThoiGianLap = c.ThoiGianLap, ThoiGianXuat = c.ThoiGianXuat, TongTien = c.TongTien, TenBan = d.Name };
            }
            else
            {
                _gc.DataSource = from c in GetData.Get.Bill()
                                 where c.ThoiGianXuat.CompareTo("Chưa Thanh Toán") != 0
                                 from d in GetData.Get.Ban()
                                 where c.IDBan.CompareTo(d.ID) == 0
                                 select new { ID = c.ID, ThoiGianLap = c.ThoiGianLap, ThoiGianXuat = c.ThoiGianXuat, TongTien = c.TongTien, TenBan = d.Name };
            }
        }

        public bool AddUser(string _sUsername, string _sPassword, string _sEmail)
        {
            LoginSystem _ls = new LoginSystem();

            _ls.ID = _sUsername;
            _ls.Pass = _sPassword;
            _ls.Email = _sEmail;

            return GetData.Get.AddUser(_ls) >= 1 ? true : false;
        }

        public bool CheckUser(string _sUsername)
        {
            return GetData.Get.Login().Where(p => p.ID.CompareTo(_sUsername) == 0).ToList().Count > 0 ? true : false;
        }

        public void TimKiemBill(ComboBoxEdit _cbb, DateTimePicker _dtp, TimeEdit _te, GridControl _gc)
        {
            Regex _regex = new Regex(@_dtp.Value.ToString("dd/MM/yyyy") + " " + _te.Text.ToString().Substring(0, 5));

            List<Bill> _listBill = GetData.Get.Bill();

            List<Bill> _list = new List<Bill>();

            if (_cbb.Text.Equals(string.Empty) == true)
            {
                foreach (Bill _b in _listBill)
                {
                    if (_regex.IsMatch(_b.ThoiGianLap) == true)
                    {
                        _list.Add(_b);
                    }
                }
            }

            if (_cbb.Text.Equals(string.Empty) == false)
            {
                string _sMaBan = (from c in GetData.Get.Ban() where c.Name.CompareTo(_cbb.Text) == 0 select c.ID).ToList()[0];

                foreach (Bill _b in _listBill)
                {
                    if (_regex.IsMatch(_b.ThoiGianLap) == true && _b.IDBan.CompareTo(_sMaBan) == 0)
                    {
                        _list.Add(_b);
                    }
                }
            }

            if (_list.Count > 0)
            {
                _gc.DataSource = from c in _list
                                 join d in GetData.Get.Ban()
                                 on c.IDBan equals d.ID
                                 select new { ID = c.ID, ThoiGianLap = c.ThoiGianLap, ThoiGianXuat = c.ThoiGianXuat, TenBan = d.Name, TongTien = c.TongTien };
            }
            else
            {
                _gc.DataSource = null;
            }

            _listBill = null;

            _list = null;

            _regex = null;
        }

        public void DoanhThu(GridControl _gc, TextEdit _txt)
        {
            List<Bill> _listBill = GetData.Get.Bill().Where(p => p.ThoiGianXuat.CompareTo("Chưa Thanh Toán") != 0).ToList();
            List<DoanhThu> _listDoanhThu = new List<DoanhThu>();

            float _fTongDoanhThu = 0f;

            int _iStt = 1;

            foreach (Bill _b in _listBill)
            {
                string _s = _b.ThoiGianLap.Substring(0, 10);

                foreach (DoanhThu _dt in _listDoanhThu)
                {
                    if (_dt.Ngay.CompareTo(_s) == 0)
                    {
                        _s = "";

                        break;
                    }
                }

                if (_s.Equals(string.Empty) == false)
                {
                    DoanhThu _dt = new DoanhThu();

                    _dt.STT += _iStt;
                    _dt.Ngay = _s;

                    _listDoanhThu.Add(_dt);

                    _dt = null;

                    _iStt++;
                }
            }

            for (int _i = 0; _i < _listDoanhThu.Count; _i++)
            {
                foreach (Bill _b in _listBill)
                {
                    if (_b.ThoiGianLap.Substring(0, 10).CompareTo(_listDoanhThu[_i].Ngay) == 0)
                    {
                        _listDoanhThu[_i].TongTien += _b.TongTien;
                    }
                }
                _fTongDoanhThu += _listDoanhThu[_i].TongTien;
            }

            _listBill = null;

            _gc.DataSource = _listDoanhThu;

            _txt.Text = _fTongDoanhThu.ToString();

            _listDoanhThu = null;
        }

        public void TimKiemFood(GridControl _gc, string _sName)
        {
            _gc.DataSource = null;

            _gc.DataSource = from c in GetData.Get.Food() where c.Name.Contains(_sName) select c;
        }

        public void BaoCao(string _sBaoCao, GridControl _gc, DateTimePicker _dtpTimKiem)
        {
            _gc.DataSource = null;

            List<BaoCao> _listBaoCao = new List<BaoCao>();

            string _s = "";

            int _iStt = 1;

            int _x = 0;
            int _y = 10;

            switch (_sBaoCao)
            {
                case "Ngày":
                    _s = _dtpTimKiem.Value.ToString("dd/MM/yyyy");
                    break;
                case "Tháng":
                    _s = _dtpTimKiem.Value.ToString("MM/yyyy");
                    _x = 3;
                    _y = 7;
                    break;
            }

            List<BillFood> _listBillFood =  (from c in GetData.Get.BillFood()
                                            from d in GetData.Get.Bill()
                                            where d.ThoiGianLap.ToString().Substring(_x, _y).Equals(_s) == true
                                            where d.ThoiGianXuat.Equals("Chưa Thanh Toán") == false
                                            where c.IDBill.Equals(d.ID) == true
                                            select c).ToList();

            var _item = from c in _listBillFood
                        group c by c.NameFood
                            into newSelect
                            select new { Name = newSelect.Key, SoLuong = newSelect.Sum(c => c.SoLuong), TongTien = newSelect.Sum(c => c.ThanhTien) };


            foreach (var _v in _item)
            {
                BaoCao _bc = new BaoCao();

                _bc.STT = _iStt;
                _bc.Name = _v.Name;
                _bc.SoLuong = _v.SoLuong;
                _bc.TongTien = _v.TongTien;

                _listBaoCao.Add(_bc);

                _bc = null;

                _iStt++;
            }

            _gc.DataSource = _listBaoCao;

            _listBaoCao = null;

            _s = "";
        }

        public bool ThemChucVu(string _sTenChucVu)
        {
            ChucVu _cv = new ChucVu();

            _cv.Name = _sTenChucVu;

            return GetData.Get.ThemChucVu(_cv) >= 1 ? true : false;
        }

        public bool SuaChucVu(string _sId, string _sTenChucVu)
        {
            List<NhanVien> _listNhanVien = (GetData.Get.NhanVien().Where(p => p.IDChucVu.Equals(_sId) == true).Select(p => p)).ToList();

            ChucVu _cv = new ChucVu();

            _cv.ID = _sId;
            _cv.Name = _sTenChucVu;

            return GetData.Get.SuaChucVu(_cv, _listNhanVien) >= _listNhanVien.Count + 1 ? true : false;
        }

        public bool XoaChucVu(string _sId)
        {
            ChucVu _cv = new ChucVu();

            _cv.ID = _sId;

            return GetData.Get.XoaChucVu(_cv) >= 1 ? true : false;
        }

        public bool CheckXoaChucVu(string _sId)
        {
            return (from c in GetData.Get.NhanVien()
                    where c.IDChucVu.Equals(_sId) == true
                    select c).Count() > 0 ? true : false;
        }

        public bool CheckThemSuaChucVu(string _sTenChucVu)
        {
            return (from c in GetData.Get.ChucVu() where c.Name.Equals(_sTenChucVu, StringComparison.CurrentCultureIgnoreCase) == true select c).ToList().Count > 0 ? true : false;
        }

        public void TimKiemNhanVien(GridControl _gc, string _sName)
        {
            _gc.DataSource = null;

            _gc.DataSource = from c in GetData.Get.NhanVien()
                             from d in GetData.Get.ChucVu()
                             where c.Name.Contains(_sName)
                             where c.IDChucVu.Equals(d.ID) == true
                             select new { ID = c.ID, Name = c.Name, Phone = c.Phone, Email = c.Email, Sex = c.Sex, Brithday = c.Brithday, Luong = c.Luong, TenChucVu = d.Name };
        }

        public void DoubleClickChucVu(string _sId, GridControl _gc)
        {
            _gc.DataSource = null;

            _gc.DataSource = from c in GetData.Get.NhanVien()
                             from d in GetData.Get.ChucVu()
                             where c.IDChucVu.Equals(_sId) == true
                             where d.ID.Equals(_sId) == true
                             select new { ID = c.ID, Name = c.Name, Phone = c.Phone, Email = c.Email, Sex = c.Sex, Brithday = c.Brithday, Luong = c.Luong, TenChucVu = d.Name };
        }

        private string HopThoai()
        {
            SaveFileDialog _sfd = new SaveFileDialog();

            string _s = "";

            _sfd.Filter = "Excel|*.xlsx";

            if(_sfd.ShowDialog() == DialogResult.OK)
                _s = _sfd.FileName;

            _sfd = null;

            return _s;
        }

        public void XuatExcelDoanhThu(GridView _gv, string _sName, string _sTongTien)
        {
            string _sPath = HopThoai();

            if(_sPath.Equals(string.Empty) == false)
            {
                Microsoft.Office.Interop.Excel.Application _app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook _workBook = _app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet _workSheet = null;

                try
                {
                    _f.ppLoad.Visible = true;

                    _workSheet = _workBook.ActiveSheet;

                    _workSheet.Name = _sName;

                    _workSheet.Range[_workSheet.Cells[1, 1], _workSheet.Cells[1, _gv.DataRowCount]].Merge();

                    _workSheet.Cells[1, 1].Value = _sName;

                    _workSheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    _workSheet.Cells[1, 1].Font.Size = 14;

                    _workSheet.Cells[1, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                    for (int _i = 1; _i <= _gv.Columns.Count; _i++)
                    {
                        if (_gv.Columns[_i - 1].Caption.Contains("ID") == true)
                        {
                            continue;
                        }

                        _workSheet.Cells[2, _i] = _gv.Columns[_i - 1].Caption;

                        _workSheet.Cells[2, _i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                        _workSheet.Cells[2, _i].Font.Size = 14;

                        _workSheet.Cells[2, _i].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                    }

                    for (int _i = 1; _i <= _gv.DataRowCount; _i++)
                    {
                        for (int _j = 1; _j <= _gv.Columns.Count; _j++)
                        {
                            _workSheet.Cells[_i + 2, _j] = _gv.GetRowCellValue(_i - 1, _gv.Columns[_j - 1].FieldName);

                            _workSheet.Cells[1, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        }
                    }

                    if (_sTongTien.Equals(string.Empty) == false)
                    {
                        _workSheet.Cells[_gv.DataRowCount + 3, 1] = _sTongTien;
                    }

                    _workBook.SaveAs(_sPath);

                    XtraMessageBox.Show("In Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    if(XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        Transfer.Trans.XuatExcelDoanhThu(_gv, _sName, _sTongTien);
                    }
                }
                finally
                {
                    _app.Quit();

                    _app = null;

                    _workBook = null;

                    _workSheet = null;

                    _f.ppLoad.Visible = false;
                }
            }
        }

        private string LayThuHienTai()
        {
            string _sThu = "";

            switch(DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    _sThu = "Thứ hai";
                    break;
                case "Tuesday":
                    _sThu = "Thứ ba";
                    break;
                case "Wednesday":
                    _sThu = "Thứ tư";
                    break;
                case "Thursday":
                    _sThu = "Thứ năm";
                    break;
                case "Friday":
                    _sThu = "Thứ sáu";
                    break;
                case "Saturday":
                    _sThu = "Thứ bảy";
                    break;
                case "Sunday":
                    _sThu = "Chủ nhật";
                    break;
            }

            return _sThu;
        }

        public void DanhSachCa(string _sThu, GridControl _gc)
        {
            List<DanhSachCa> _listDanhSachCa = GetData.Get.DanhSachCa();
            List<NhanVien> _listNhanVien = GetData.Get.NhanVien();

            _gc.DataSource = from c in _listDanhSachCa
                             from d in _listNhanVien
                             where c.Thu.Equals(_sThu) == true
                             where c.IDNhanVien.Equals(d.ID) == true
                             select new { ID = c.ID, Thu = c.Thu, GioLam = c.GioLam, GioKetThuc = c.GioKetThuc, CheckCa = c.CheckCa, TenNhanVien = d.Name, IDNhanVien = c.IDNhanVien };
        }

        public bool DiemDanh(string _sIdCa, bool _bCheckCa, string _sThu, string _sIdNhanVien, string _sTienTru)
        {
            if(_sThu.Equals(LayThuHienTai()) == false)
            {
                return false;
            }

            List<DanhSachCa> _listDanhSachCa = (from c in GetData.Get.DanhSachCa()
                      where c.Thu.Equals(_sThu) == true
                      where c.IDNhanVien.Equals(_sIdNhanVien) == true
                      select c).ToList();

            if(_listDanhSachCa.Count == 1)
            {
                bool _bCheckCaBanDau = _listDanhSachCa[0].CheckCa;

                if(_bCheckCaBanDau == _bCheckCa)
                {
                    return false;
                }

                NgayNghi _nn = new NgayNghi();

                _listDanhSachCa[0].CheckCa = _bCheckCa;

                if(_bCheckCaBanDau == true && _bCheckCa == false)
                {
                    _nn.Ngay = DateTime.Now.ToString("dd/MM/yyyy");
                    _nn.IDNhanVien = _sIdNhanVien;
                }

                if(_bCheckCaBanDau == false && _bCheckCa == true)
                {
                    _nn = (from c in GetData.Get.NgayNghi() where c.IDNhanVien.Equals(_sIdNhanVien) == true
                           where c.Ngay.Equals(DateTime.Now.ToString("dd/MM/yyyy")) == true
                           select c).ToList()[0];
                }

                return GetData.Get.DiemDanhNgay(_listDanhSachCa[0], _nn, _bCheckCa) >= 2 ? true : false;
            }
            else if (_listDanhSachCa.Count > 1)
            {
                DanhSachCa _dsc = (from c in _listDanhSachCa where c.ID.Equals(_sIdCa) == true select c).ToList()[0];

                bool _bCheckCaBanDau = _dsc.CheckCa;

                if(_bCheckCaBanDau == _bCheckCa)
                {
                    return false;
                }

                int _j = 0;
                int _k = 0;

                for (int _i = 0; _i < _listDanhSachCa.Count; _i++)
                {
                    if (_listDanhSachCa[_i].CheckCa == false)
                    {
                        _j++;
                    }
                }

                if (_j == _listDanhSachCa.Count)
                {
                    List<CaNghi> _listCaNghi = new List<CaNghi>();

                    foreach(DanhSachCa _dsc1 in _listDanhSachCa)
                    {
                        if(_dsc1.CheckCa == false && _dsc1.ID.Equals(_dsc.ID) == false)
                        {
                            CaNghi _cn = new CaNghi();

                            _cn.NgayNghi = DateTime.Now.ToString("dd/MM/yyyy");
                            _cn.GioLam = _dsc1.GioLam;
                            _cn.IDNhanVien = _dsc.IDNhanVien;

                            _listCaNghi.Add(_cn);

                            _cn = null;
                        }
                    }

                    _dsc.CheckCa = true;

                    NgayNghi _nn = (from c in GetData.Get.NgayNghi() where c.IDNhanVien.Equals(_dsc.IDNhanVien) == true
                                   where c.Ngay.Equals(DateTime.Now.ToString("dd/MM/yyyy")) == true select c).ToList()[0];

                    return GetData.Get.RefeshChuyenNgayThanhCa(_dsc, _nn, _listCaNghi) >= _listCaNghi.Count + 2 ? true : false;
                }

                _j = 0;

                for (int _i = 0; _i < _listDanhSachCa.Count; _i++)
                {
                    if (_listDanhSachCa[_i].CheckCa == false && _listDanhSachCa[_i].ID.Equals(_dsc.ID) == false)
                    {
                        _j++;
                        continue;
                    }

                    _k = _i;
                }

                if(_j == _listDanhSachCa.Count - 1)
                {
                    CaNghi _cn = (from c in GetData.Get.CaNghi() where c.NgayNghi.Equals(DateTime.Now.ToString("dd/MM/yyyy")) == true
                                 where c.IDNhanVien.Equals(_dsc.IDNhanVien) == true select c).ToList()[0];

                    NgayNghi _nn = new NgayNghi(){ Ngay = DateTime.Now.ToString("dd/MM/yyyy"), IDNhanVien = _dsc.IDNhanVien };

                    _dsc.CheckCa = _bCheckCa;

                    return GetData.Get.ChuyenCaThanhNgay(_cn, _nn, _dsc) >= 3 ? true : false;
                }

                CaNghi _caNghi = new CaNghi();

                _dsc.CheckCa = _bCheckCa;

                if(_bCheckCaBanDau == true && _bCheckCa == false)
                {
                    _caNghi.NgayNghi = DateTime.Now.ToString("dd/MM/yyyy");
                    _caNghi.GioLam = _dsc.GioLam;
                    _caNghi.IDNhanVien = _dsc.IDNhanVien;
                }

                if(_bCheckCaBanDau == false && _bCheckCa == true)
                {
                    _caNghi = (from c in GetData.Get.CaNghi()
                           where c.IDNhanVien.Equals(_dsc.IDNhanVien) == true
                           where c.GioLam.Equals(_dsc.GioLam) == true
                           where c.NgayNghi.Equals(DateTime.Now.ToString("dd/MM/yyyy")) == true
                           select c).ToList()[0];
                }

                return GetData.Get.DiemDanhCa(_dsc, _caNghi, _bCheckCa) >= 2 ? true : false;
            }

            return true;
        }

        public void LoadNhanVienComboBox(System.Windows.Forms.ComboBox _cbb)
        {
            _cbb.DataSource = null;

            _cbb.DataSource = GetData.Get.NhanVien();
            _cbb.DisplayMember = "Name";
            _cbb.ValueMember = "ID";
        }

        public int ThemCa(string _sThu, string _sGioLam, string _sGioKetThuc, string _sIDNhanVien)
        {
            if(_sThu.Equals(LayThuHienTai()) == true)
            {
                return -1;
            }

            bool _b = (from c in GetData.Get.DanhSachCa()
                      where c.GioKetThuc.Equals(_sGioKetThuc) == true
                      where c.GioLam.Equals(_sGioLam) == true
                      where c.Thu.Equals(_sThu) == true
                      where c.IDNhanVien.Equals(_sIDNhanVien) == true
                      select c).Count() > 0 ? true : false;

            if(_b == true)
            {
                return 0;
            }

            DanhSachCa _dsc = new DanhSachCa() { Thu = _sThu, GioLam = _sGioLam, GioKetThuc = _sGioKetThuc, CheckCa = true, IDNhanVien = _sIDNhanVien };

            return GetData.Get.ThemCa(_dsc) >= 1 ? 1 : 2;
        }

        public bool RemoveCa(string _sIDCa, string _sIDNhanVien, string _sThu)
        {
            if(_sThu.Equals(LayThuHienTai()) == true)
            {
                return false;
            }

            DanhSachCa _dsc = (from c in GetData.Get.DanhSachCa()
                               where c.ID.Equals(_sIDCa) == true
                               where c.IDNhanVien.Equals(_sIDNhanVien) == true
                               select c).ToList()[0];

            return GetData.Get.RemoveCa(_dsc) >= 1 ? true : false;
        }

        public int EditCa(string _sIDCa, string _sIDNhanVien, string _sGioLam, string _sGioKetThuc, string _sThu)
        {
            if(_sThu.Equals(LayThuHienTai()) == true)
            {
                return -1;
            }

            bool _b = (from c in GetData.Get.DanhSachCa()
                      where c.GioLam.Equals(_sGioLam) == true
                      where c.GioKetThuc.Equals(_sGioKetThuc) == true
                      where c.Thu.Equals(_sThu) == true
                      where c.IDNhanVien.Equals(_sIDNhanVien) == true
                      select c).Count() > 0 ? true : false;

            if(_b == true)
            {
                return 0;
            }

            DanhSachCa _dsc = new DanhSachCa();

            _dsc.ID = _sIDCa;
            _dsc.IDNhanVien = _sIDNhanVien;
            _dsc.GioLam = _sGioLam;
            _dsc.GioKetThuc = _sGioKetThuc;
            _dsc.CheckCa = true;

            return GetData.Get.EditCa(_dsc) >= 1 ? 1 : 2;
        }

        public void LuongNhanVien(GridControl _gc)
        {
            List<NhanVien> _listNhanVien = GetData.Get.NhanVien();
            List<ChucVu> _listChucVu = GetData.Get.ChucVu();

            var _item = from c in _listNhanVien
                             from d in _listChucVu
                             where c.IDChucVu.Equals(d.ID) == true
                             select new { ID = c.ID, Name = c.Name, Phone = c.Phone, Email = c.Email, Luong = c.Luong, TenChucVu = d.Name };

            _gc.DataSource = null;

            _gc.DataSource = _item.ToList();

            _listNhanVien = null;

            _listChucVu = null;
        }

        public void DanhSachNgayNghi(string _sIDNhanVien, GridControl _gc)
        {
            List<NgayNghi> _listNgayNghi = GetData.Get.NgayNghi();

            _listNgayNghi = (from c in _listNgayNghi
                             where c.IDNhanVien.Equals(_sIDNhanVien) == true
                             select c).ToList();

            List<CaNghi> _listCaNghi = GetData.Get.CaNghi();

            _listCaNghi = (from c in _listCaNghi
                           where c.IDNhanVien.Equals(_sIDNhanVien) == true
                           select c).ToList();

            List<LuongNhanVien> _listLuongNhanVien = new List<LuongNhanVien>();

            foreach(NgayNghi _nn in _listNgayNghi)
            {
                LuongNhanVien _lnv = new LuongNhanVien();

                _lnv.Ngay = _nn.Ngay;
                _lnv.ChuThich = "Vắng";

                _listLuongNhanVien.Add(_lnv);

                _lnv = null;
            }

            foreach(CaNghi _cn in _listCaNghi)
            {
                LuongNhanVien _lnv = new LuongNhanVien();

                _lnv.Ngay = _cn.NgayNghi;
                _lnv.ChuThich = _cn.GioLam;

                _listLuongNhanVien.Add(_lnv);

                _lnv = null;
            }

            _gc.DataSource = null;

            _gc.DataSource = _listLuongNhanVien;

            _listNgayNghi = null;

            _listCaNghi = null;

            _listLuongNhanVien = null;
        }

        public bool SetLuongTam(string _sIDNhanVien, string _fLuong)
        {
            LuongTam _lt = new LuongTam();

            _lt.IDNhanVien = _sIDNhanVien;
            _lt.Luong = Convert.ToSingle(_fLuong);

            return GetData.Get.UpdateLuongTam(_lt) >= 1 ? true : false;
        }

        public float LuongTam(string _sIDNhanVien)
        {
            return (GetData.Get.LuongTam().Where(p => p.IDNhanVien.Equals(_sIDNhanVien) == true).Select(p => p.Luong)).ToList()[0];
        }

        public void XuatExcelLuongNhanVien(GridView _gvLuongNhanVien, GridView _gvNgayNghi)
        {
            string _sPath = HopThoai();

            if(_sPath.Equals(string.Empty) == false)
            {
                _f.ppLoad.Visible = true;

                string _sMaNhanVien = _gvLuongNhanVien.GetRowCellValue(_gvLuongNhanVien.GetSelectedRows()[0], "ID").ToString();
                string _sTenNhanVien = _gvLuongNhanVien.GetRowCellValue(_gvLuongNhanVien.GetSelectedRows()[0], "Name").ToString();
                float _fLuong = GetData.Get.LuongTam().Where(p => p.IDNhanVien.Equals(_sMaNhanVien) == true).Select(p => p.Luong).ToList()[0];

                List<NgayNghi> _listNgayNghi = GetData.Get.NgayNghi().Where(p => p.IDNhanVien.Equals(_sMaNhanVien)).ToList();
                List<CaNghi> _listCaNghi = GetData.Get.CaNghi().Where(p => p.IDNhanVien.Equals(_sMaNhanVien)).ToList();

                Microsoft.Office.Interop.Excel.Application _app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbook _workBook = _app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet _workSheet = null;

                try
                {
                    _workSheet = _workBook.ActiveSheet;

                    _workSheet.Name = "Lương " + _sTenNhanVien;

                    _workSheet.Range[_workSheet.Cells[1, 1], _workSheet.Cells[1, _listNgayNghi.Count() + _listCaNghi.Count()]].Merge();

                    _workSheet.Cells[1, 1].Value = "Chi tiết Lương " + _sTenNhanVien;

                    _workSheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    _workSheet.Cells[1, 1].Font.Size = 14;

                    _workSheet.Cells[1, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

                    for (int _i = 1; _i <= _gvNgayNghi.Columns.Count - 1; _i++)
                    {
                        _workSheet.Cells[2, _i] = _gvNgayNghi.Columns[_i].Caption;

                        _workSheet.Cells[2, _i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                        _workSheet.Cells[2, _i].Font.Size = 14;

                        _workSheet.Cells[2, _i].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                    }

                    for (int _i = 1; _i <= _gvLuongNhanVien.GetSelectedRows().Count(); _i++)
                    {
                        for (int _j = 1; _j <= _gvNgayNghi.Columns.Count - 1; _j++)
                        {
                            _workSheet.Cells[_i + 2, _j] = _gvLuongNhanVien.GetRowCellValue(_gvLuongNhanVien.GetSelectedRows()[0], _gvNgayNghi.Columns[_j]);

                            _workSheet.Cells[1, 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        }
                    }

                    _workSheet.Cells[_listCaNghi.Count + _listNgayNghi.Count + 3, 1] = "Lương tổng " + _fLuong.ToString();
                    
                    _workBook.SaveAs(_sPath);

                    XtraMessageBox.Show("In Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //if (XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    //{
                    //    Transfer.Trans.XuatExcelLuongNhanVien(_gvLuongNhanVien, _gvNgayNghi);
                    //}
                }
                finally
                {
                    _app.Quit();

                    _app = null;

                    _workBook = null;

                    _workSheet = null;

                    _f.ppLoad.Visible = false;
                }
            }
        }
    }
}
