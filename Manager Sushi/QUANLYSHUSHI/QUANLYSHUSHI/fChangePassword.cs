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
using DevExpress.XtraEditors;
using QUANLYSHUSHI.BLL;

namespace QUANLYSHUSHI
{
    public partial class fChangePassword : Form
    {
        private string _sTaiKhoan = null;

        public fChangePassword()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        public fChangePassword(string _sTaiKhoan):this()
        {
            this._sTaiKhoan = _sTaiKhoan;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.ShushiIcon);

            GraphicsUserInterface.GraphicsUsers.PaintPanel(_g, "Thay đổi mật khẩu", 38, 6, _bm);

            _g.Dispose();

            _bm.Dispose();
        }

        private void fTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.Lock);

            GraphicsUserInterface.GraphicsUsers.PainForm(_g, 0, 40, 120, 130, _bm);

            _g.Dispose();

            _bm.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtNhapMatKhauCu.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauCu.Focus();
                return;
            }

            if (Transfer.Trans.CheckLogin(txtTaiKhoan.Text, txtNhapMatKhauCu.Text) == false)
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauCu.Focus();
                return;
            }

            if(txtNhapMatKhauMoi.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                return;
            }

            if (txtNhapMatKhauMoi.Text.Equals(txtNhapMatKhauCu.Text) == true)
            {
                XtraMessageBox.Show("Mật khẩu mới trùng Mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                return;
            }

            if (Check.CheckChar(txtNhapMatKhauMoi.Text) == false)
            {
                XtraMessageBox.Show("Mật khẩu mới không được chứa ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauCu.ResetText();
                txtNhapMatKhauCu.Focus();
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtNhapMatKhauMoi.Text) == 1)
            {
                XtraMessageBox.Show("Mật khẩu mới phải bằng hoặc trên 8 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtNhapMatKhauMoi.Text) == 2)
            {
                XtraMessageBox.Show("Ký tự đầu tiên của Mật khẩu mới phải là Chữ cái và Viết hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                txtNhapMatKhauMoi.Select(0, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtNhapMatKhauMoi.Text) == 3)
            {
                XtraMessageBox.Show("Ký tự đầu tiên của Mật khẩu mới phải Viết Hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                txtNhapMatKhauMoi.Select(0, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtNhapMatKhauMoi.Text) == 4)
            {
                XtraMessageBox.Show("Ký tự thứ hai của Mật khẩu mới phải là Chữ cái và Viết thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                txtNhapMatKhauMoi.Select(1, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtNhapMatKhauMoi.Text) == 5)
            {
                XtraMessageBox.Show("Ký tự thứ hai của Mật khẩu mới phải là Chữ cái và Viết thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMatKhauMoi.Focus();
                txtNhapMatKhauMoi.Select(1, 1);
                return;
            }

            if (txtNhapLaiMatKhauMoi.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhauMoi.Focus();
                return;
            }

            if(txtNhapLaiMatKhauMoi.Text.CompareTo(txtNhapMatKhauMoi.Text) != 0)
            {
                XtraMessageBox.Show("Nhập lại mật khẩu không chính xác với Mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhauMoi.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            if(Transfer.Trans.ChangePassword(txtTaiKhoan.Text, txtNhapMatKhauMoi.Text) == true)
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Đổi Mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = _sTaiKhoan;

            _sTaiKhoan = null;
        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextEdit _txt = sender as TextEdit;

            if(_txt.Text.Equals(string.Empty) == false)
            {
                _txt.SelectAll();
            }
        }
    }
}
