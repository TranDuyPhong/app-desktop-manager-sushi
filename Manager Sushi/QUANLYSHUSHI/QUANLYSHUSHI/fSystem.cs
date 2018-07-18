using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSHUSHI.GUI;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Navigation;
using System.Threading;
using QUANLYSHUSHI.BLL;
using DevExpress.XtraEditors;
using QUANLYSHUSHI.MODEL;
using DevExpress.XtraGrid.Views.Grid;

namespace QUANLYSHUSHI
{
    public partial class fSystem : Form
    {
        public List<Food> _listFoodThucDon = null;
        public List<SimpleButton> _listButton = null;
        private fAddUser _fAddUser = null;
        private fThucDon _fThucDon = null;
        private Form _form = null;
        private fChangePassword _fChangePassword = null;
        private UCMonAn _ucMonAn = null;
        private UCBill _ucBill = null;
        private UCDoanhThu _ucDoanhThu = null;
        private UCNhanVien _ucNhanVien = null;
        private UCBaoCaoNgay _ucBaoCaoNgay = null;
        private UCBaoCaoThang _ucBaoCaoThang = null;
        private UCChucVu _ucChucVu = null;
        private UCDanhSachCa _ucDanhSachCa = null;
        private UCLuongNhanVien _ucLuongNhanVien = null;

        public string _sMaBan = "";
        public string _sUsername = null;
        private int _iMouseX;
        private int _iMouseY;

        public Form FormLoginSystem
        {
            get { return _form; }
            set { _form = value; }
        }

        private void MouseMovePanel(object sender, MouseEventArgs e)
        {
            if (sender is Panel)
            {
                if (e.Button == MouseButtons.Left)
                    this.Location = new Point(Cursor.Position.X - _iMouseX, Cursor.Position.Y - _iMouseY);
            }
        }

        private void MouseDownPanel(object sender, MouseEventArgs e)
        {
            _iMouseX = e.X;
            _iMouseY = e.Y;
        }

        public fSystem()
        {
            InitializeComponent();

            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

            _listButton = Transfer.Trans.Ban(pnBan, Properties.Resources.Table3, Properties.Resources.Table4, cbbBan);

            Transfer.System = this;

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPanel(sender, e);
        }

        private void pnTitle_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMovePanel(sender, e);
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.ShushiIcon);

            Font _font = new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic);

            _g.DrawString("Hôm Nay Là " + GetDay() + " --" + " Xin Chào " + _sUsername, _font, Brushes.White, new PointF(700, 10));

            GraphicsUserInterface.GraphicsUsers.PaintPanel(_g, "Phần Mềm Quản Lý Quán Shushi", 38, 6, _bm);

            _bm.Dispose();

            _g.Dispose();

            _font.Dispose();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;

            btnMaximize.Image = this.WindowState == FormWindowState.Maximized ? Properties.Resources.Normal : Properties.Resources.Maximize;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (GraphicsUserInterface.GraphicsUsers._th.ThreadState == System.Threading.ThreadState.Running)
                {
                    GraphicsUserInterface.GraphicsUsers._th.Abort();
                }

                if (GraphicsUserInterface.GraphicsUsers._th != null)
                {
                    GraphicsUserInterface.GraphicsUsers._th = null;
                }
            }
            catch { }

            this.Close();

            _form.Show();
        }

        private string GetDay()
        {
            string _s = DateTime.Now.DayOfWeek.ToString();

            switch(_s)
            {
                case "Monday":
                    _s = "Thứ Hai";
                    break;
                case "Tuesday":
                    _s = "Thứ Ba";
                    break;
                case "Wednesday":
                    _s = "Thứ Tư";
                    break;
                case "Thursday":
                    _s = "Thứ Năm";
                    break;
                case "Friday":
                    _s = "Thứ Sáu";
                    break;
                case "Saturday":
                    _s = "Thứ Bảy";
                    break;
                case "Sunday":
                    _s = "Chủ Nhật";
                    break;
            }

            return _s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            _fChangePassword = new fChangePassword(_sUsername);

            _fChangePassword.ShowDialog();

            _fChangePassword = null;
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
          
        }

        private void btnKhachHangVip_Click(object sender, EventArgs e)
        {
         
        }

        private void cbbBan_EditValueChanged(object sender, EventArgs e)
        {
            _sMaBan = (sender as LookUpEdit).EditValue.ToString();

            Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(_sMaBan.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chựa chọn Bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.CheckBan(_sMaBan) == true)
            {
                XtraMessageBox.Show("Bàn này đã có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dgvThucDon.SelectedRows.Count <= 0)
            {
                XtraMessageBox.Show("Chưa chọn Món ăn, hãy chọn Món ăn từ Danh sách Món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int _i = 0; _i < dgvThucDon.SelectedRows.Count; _i++)
            {
                if (dgvThucDon.SelectedRows[_i].Cells["SoLuong"].Value != null)
                {
                    string _s = dgvThucDon.SelectedRows[_i].Cells["SoLuong"].Value.ToString();

                    if (Convert.ToByte(_s) <= 0)
                    {
                        XtraMessageBox.Show("Món ăn bạn chọn chưa set Số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Check.CheckChar(_s) == false)
                    {
                        XtraMessageBox.Show("Số lượng không được chứa ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Check.CheckNumber(_s) == false)
                    {
                        XtraMessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Món ăn bạn chọn không có hoặc rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            List<BillFood> _listBillFood = new List<BillFood>();
            Bill _b = new Bill() { ThoiGianLap = DateTime.Now.ToString("hh/MM/yyyy hh:mm:ss"), ThoiGianXuat = "Chưa Kết Bill", IDBan = _sMaBan };

            for (int _i = 0; _i < dgvThucDon.SelectedRows.Count; _i++)
            {
                if (dgvThucDon.SelectedRows[_i].Cells["ID"].Value != null)
                {
                    BillFood _bf = new BillFood();

                    _bf.IDFood = dgvThucDon.SelectedRows[_i].Cells["ID"].Value.ToString();
                    _bf.NameFood = dgvThucDon.SelectedRows[_i].Cells["Name"].Value.ToString();
                    _bf.Gia = (float)Convert.ToDouble(dgvThucDon.SelectedRows[_i].Cells["Price"].Value);
                    _bf.SoLuong = Convert.ToByte(dgvThucDon.SelectedRows[_i].Cells["SoLuong"].Value.ToString());
                    _bf.IDBan = _sMaBan;

                    _listBillFood.Add(_bf);
                }
            }

            if(Transfer.Trans.AddBill(_b, _listBillFood) == true)
            {
                XtraMessageBox.Show("Order thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);

                _listButton = null;

                _listButton = Transfer.Trans.Ban(pnBan, Properties.Resources.Table3, Properties.Resources.Table4, cbbBan);

                ResetSoLuong();
            }

            _sMaBan = "";

            _listBillFood = null;

            _b = null;
        }

        private void btnThemThucDon_Click(object sender, EventArgs e)
        {
            _listFoodThucDon = new List<Food>();
            for (int _i = 0; _i < dgvThucDon.Rows.Count; _i++)
            {
                if(dgvThucDon["ID", _i].Value != null)
                {
                    Food _f = new Food();

                    _f.ID = dgvThucDon["ID", _i].Value.ToString();
                    _f.Name = dgvThucDon["Name", _i].Value.ToString();
                    _f.Price = (float)Convert.ToDouble(dgvThucDon["Price", _i].Value.ToString());

                    _listFoodThucDon.Add(_f);

                    _f = null;
                }
            }

            _fThucDon = new fThucDon();

            _fThucDon._f = this;

            _fThucDon._listThucDon = _listFoodThucDon;

            _fThucDon.ShowDialog();

            _fThucDon = null;
        }

        private void btnBanCoNguoi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Transfer.Trans.SortBan("Có người", pnBan, _listButton);

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnBanTrong_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Transfer.Trans.SortBan("Trống", pnBan, _listButton);

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnTatCaBan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            _listButton = null;

            _listButton = Transfer.Trans.Ban(pnBan, Properties.Resources.Table3, Properties.Resources.Table4, cbbBan);

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_sMaBan) == true)
            {
                XtraMessageBox.Show("Bạn chưa chọn Bàn cần thêm Món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Transfer.Trans.CheckBan(_sMaBan) == false)
            {
                XtraMessageBox.Show("Bạn này không có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dgvThucDon.SelectedRows.Count <= 0)
            {
                XtraMessageBox.Show("Chưa chọn Món ăn cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int _i = 0; _i < dgvThucDon.SelectedRows.Count; _i++)
            {
                if (dgvThucDon.SelectedRows[_i].Cells["SoLuong"].Value != null)
                {
                    string _s = dgvThucDon.SelectedRows[_i].Cells["SoLuong"].Value.ToString();

                    if (_s.StartsWith("0") == true)
                    {
                        XtraMessageBox.Show("Món ăn bạn chọn chưa set Số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Check.CheckChar(_s) == false)
                    {
                        XtraMessageBox.Show("Số lượng không được chứa ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Check.CheckNumber(_s) == false)
                    {
                        XtraMessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Món ăn bạn chọn không có hoặc rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(Transfer.Trans.AddMonAnBill(dgvThucDon, _sMaBan, dgvThucDonTheoBan) == true)
            {
                XtraMessageBox.Show("Thêm Món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);

                ResetSoLuong();
            }

            _sMaBan = "";
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_sMaBan) == true)
            {
                XtraMessageBox.Show("Chưa chọn bàn để xóa Món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dgvThucDonTheoBan.SelectedRows.Count <= 0)
            {
                XtraMessageBox.Show("Chưa chọn Món ăn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for(int _i = 0; _i < dgvThucDonTheoBan.SelectedRows.Count; _i++)
            {
                if(dgvThucDonTheoBan.SelectedRows[_i].Cells["IDBill"].Value == null)
                {
                    XtraMessageBox.Show("Thức ăn bạn muốn xóa bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(dgvThucDonTheoBan.SelectedRows.Count == dgvThucDonTheoBan.Rows.Count - 1)
            {
                if(XtraMessageBox.Show("Bạn có chắc muốn xóa hết Món ăn của Bàn này" + "\n" + "Nều xóa thì Bill của Bàn nãy sẽ bị hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if(Transfer.Trans.RemoveBillFoood(dgvThucDonTheoBan) == true)
                    {
                        XtraMessageBox.Show("Xóa Món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);

                        _listButton = null;

                        _listButton = Transfer.Trans.Ban(pnBan, Properties.Resources.Table3, Properties.Resources.Table4, cbbBan);
                    }
                }
            }
            else
            {
                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa Món ăn trong Bàn này chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Transfer.Trans.RemoveBillFoood(dgvThucDonTheoBan) == true)
                    {
                        XtraMessageBox.Show("Xóa Món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);
                    }
                }
            }

            _sMaBan = "";
        }

        private void ResetSoLuong()
        {
            if(dgvThucDon.Rows.Count - 1 > 0)
            {
                for (int _i = 0; _i < dgvThucDon.Rows.Count - 1; _i++)
                {
                    dgvThucDon["SoLuong", _i].Value = 0;
                }
            }
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_sMaBan) == true)
            {
                XtraMessageBox.Show("Chưa chọn Bàn cần sửa Món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtMonAn.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Món ăn cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtSoLuong.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa set Số Lượng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Convert.ToByte(txtSoLuong.Text) <= 0)
            {
                XtraMessageBox.Show("Số lượng phải lớn hơn 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Check.CheckChar(txtSoLuong.Text) == false)
            {
                XtraMessageBox.Show("Số lượng không được chứa ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Check.CheckNumber(txtSoLuong.Text) == false)
            {
                 XtraMessageBox.Show("Số lượng không được là chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte _b = 0;

            if(dgvThucDonTheoBan.CurrentRow.Selected)
            {
                _b = Convert.ToByte(dgvThucDonTheoBan.SelectedRows[0].Cells["SL"].Value.ToString());
            }

            if(dgvThucDonTheoBan.CurrentCell.Selected)
            {
                _b = Convert.ToByte(dgvThucDonTheoBan.SelectedCells[0].OwningRow.Cells["SL"].Value.ToString());
            }

            if(Convert.ToByte(txtSoLuong.Text) == _b)
            {
                return;
            }

            if(Convert.ToByte(txtSoLuong.Text) != _b)
            {
                if(Transfer.Trans.EditBillFood(dgvThucDonTheoBan, txtSoLuong.Text) == true)
                {
                    XtraMessageBox.Show("Sửa Món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Transfer.Trans.BillFood(_sMaBan, dgvThucDonTheoBan);
                }
                else
                {
                    XtraMessageBox.Show("Sửa Món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _sMaBan = "";
        }

        private void dgvThucDonTheoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView _dgv = sender as DataGridView;

            if(_dgv == null)
            {
                return;
            }

            if(_dgv.CurrentRow.Selected == true)
            {
                if (_dgv["TenThucAn", e.RowIndex].Value != null)
                {
                    txtMonAn.Text = _dgv.SelectedRows[0].Cells["TenThucAn"].Value.ToString();
                    txtSoLuong.Text = _dgv.SelectedRows[0].Cells["SL"].Value.ToString();

                    return;
                }
                else
                {
                    return;
                }
            }
            
            if(_dgv.CurrentCell.Selected == true)
            {
                if (_dgv[e.ColumnIndex, _dgv.SelectedCells[0].RowIndex].Value != null)
                {
                    txtMonAn.Text = _dgv.SelectedCells[0].OwningRow.Cells["TenThucAn"].Value.ToString();
                    txtSoLuong.Text = _dgv.SelectedCells[0].OwningRow.Cells["SL"].Value.ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_sMaBan) == true)
            {
                XtraMessageBox.Show("Chưa chọn Bàn để Thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Transfer.Trans.CheckBan(_sMaBan) == false)
            {
                XtraMessageBox.Show("Bạn này Trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float _fTongTien = Transfer.Trans.ThanhToan(_sMaBan, dgvThucDonTheoBan);

            if(_fTongTien != 0 && _fTongTien != 1)
            {
                XtraMessageBox.Show("Bill đã thanh toán thành công" + "\n" + "Tổng tiền Bill là: " + _fTongTien.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _listButton = Transfer.Trans.Ban(pnBan, Properties.Resources.Table3, Properties.Resources.Table4, cbbBan);
            }

            _sMaBan = "";
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            _fAddUser = new fAddUser();

            _fAddUser.ShowDialog();

            _fAddUser = null;
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            _ucMonAn = null;

            _ucMonAn = new UCMonAn();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucMonAn);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            _ucBill = null;

            _ucBill = new UCBill();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucBill);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            _ucDoanhThu = null;

            _ucDoanhThu = new UCDoanhThu();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucDoanhThu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            _ucNhanVien = null;

            _ucNhanVien = new UCNhanVien();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucNhanVien);
        }

        private void btnBaoCaoNgay_Click(object sender, EventArgs e)
        {
            _ucBaoCaoNgay = null;

            _ucBaoCaoNgay = new UCBaoCaoNgay();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucBaoCaoNgay);
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            _ucBaoCaoThang = null;

            _ucBaoCaoThang = new UCBaoCaoThang();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucBaoCaoThang);
        }

        private void btnLuongNhanVien_Click(object sender, EventArgs e)
        {
            _ucLuongNhanVien = null;

            _ucLuongNhanVien = new UCLuongNhanVien();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucLuongNhanVien);
        }

        private void btnDanhSachCa_Click(object sender, EventArgs e)
        {
            _ucDanhSachCa = null;

            _ucDanhSachCa = new UCDanhSachCa();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucDanhSachCa);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            _ucChucVu = null;

            _ucChucVu = new UCChucVu();

            pnBan.Controls.Clear();

            pnBan.Controls.Add(_ucChucVu);
        }
    }
}
