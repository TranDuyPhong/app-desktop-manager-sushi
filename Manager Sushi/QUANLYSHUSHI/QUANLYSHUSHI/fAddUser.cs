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
using QUANLYSHUSHI.BLL;
using DevExpress.XtraEditors;

namespace QUANLYSHUSHI
{
    public partial class fAddUser : Form
    {
        public fAddUser()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.ShushiIcon);

            GraphicsUserInterface.GraphicsUsers.PaintPanel(_g, "Thêm Tài Khoản", 38, 6, _bm);

            _bm.Dispose();

            _g.Dispose();
        }

        private void fAddUser_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.AddUser);

            GraphicsUserInterface.GraphicsUsers.PainForm(_g, 0, 60, 120, 130, _bm);

            _g.Dispose();

            _bm.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (Transfer.Trans.CheckUser(txtTaiKhoan.Text) == true)
            {
                XtraMessageBox.Show("Tài khoản này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtTaiKhoan.Text.Length < 5)
            {
                XtraMessageBox.Show("Tài khoản phải bằng hoặc trên 5 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if(txtMatKhau.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtMatKhau.Text) == 1)
            {
                XtraMessageBox.Show("Mật khẩu phải bằng hoặc trên 8 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtMatKhau.Text) == 2)
            {
                XtraMessageBox.Show("Ký tự đầu tiên của Mật khẩu phải là Chữ cái và Viết hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                txtMatKhau.Select(0, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtMatKhau.Text) == 3)
            {
                XtraMessageBox.Show("Ký tự đầu tiên của Mật khẩu phải Viết Hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                txtMatKhau.Select(0, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtMatKhau.Text) == 4)
            {
                XtraMessageBox.Show("Ký tự thứ hai của Mật khẩu phải là Chữ cái và Viết thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                txtMatKhau.Select(1, 1);
                return;
            }

            if (GraphicsUserInterface.GraphicsUsers.NotePassWord(txtMatKhau.Text) == 5)
            {
                XtraMessageBox.Show("Ký tự thứ hai của Mật khẩu phải là Chữ cái và Viết thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                txtMatKhau.Select(1, 1);
                return;
            }

            if (txtMatKhau.Text.CompareTo(txtNhapLaiMatKhau.Text) != 0)
            {
                XtraMessageBox.Show("Mật khẩu nhập lại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
                return;
            }
            
            if(txtEmail.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Gmail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if(txtEmail.Text.Contains("@gmail.com") == false)
            {
                XtraMessageBox.Show("Email phải đúng định dạng abc@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            if(Transfer.Trans.AddUser(txtTaiKhoan.Text, GraphicsUserInterface.GraphicsUsers.MaHoa(txtMatKhau.Text), txtEmail.Text) == true)
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Thêm Tài khoản thành công " + "\n" + "Bạn hãy kiểm tra Email của mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GraphicsUserInterface.GraphicsUsers.SendMail("Email gửi từ Phần Mềm Quản Lý Shushi", "Bạn đã tạo một Tài khoản mới" + "\n" + "Tài khoản: " + txtTaiKhoan.Text +
                    "\n" + "Mật khẩu: " + txtMatKhau.Text + "\n" + "Nếu quên Mật khẩu bạn có thể dùng Email này của bạn để lấy lại Mật khẩu", txtEmail.Text);

                this.Close();
            }
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
