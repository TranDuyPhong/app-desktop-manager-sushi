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
    public partial class fLoginSystem : Form
    {
        private int _iMouseX;
        private int _iMouseY;
        private Form _form = null;
        private fSystem _fSystem = null;
        private fForgetPassword _fForgetPassword = null;

        public Form FormSystem
        {
            get { return _form; }
            set { _form = value; }
        }

        public fLoginSystem()
        {
            InitializeComponent();

            notifyIcon1.ShowBalloonTip(2000, "Chào " + Environment.UserName.ToString(), "Phần Mềm Quản Lý Sushi by ndbTeam", ToolTipIcon.Info);

            EmailUser.User = "cuncon271295@gmail.com";
            EmailUser.Pass = "cn0918299862";

            ForgetPassword.Password = "SushiSaba";

            txtUsername.Focus();

            ButtonTab(0, 142, 10, 34);

            txtPassword.Properties.UseSystemPasswordChar = true;

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }
        
        private void MouseDownPanel(object sender, MouseEventArgs e)
        {
            _iMouseX = e.X;
            _iMouseY = e.Y;
        }

        private void MouseMovePanel(object sender, MouseEventArgs e)
        {
            if(sender is Panel)
            {
                if(e.Button == MouseButtons.Left)
                    this.Location = new Point(Cursor.Position.X - _iMouseX, Cursor.Position.Y - _iMouseY);
            }
        }

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPanel(sender, e);
        }

        private void pnTitle_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMovePanel(sender, e);
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

            if (GraphicsUserInterface.GraphicsUsers.CloseMessage() == true)
                Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GraphicsUserInterface.GraphicsUsers.CloseMessage() == true)
                Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            _fForgetPassword = new fForgetPassword();

            _fForgetPassword.LoginSystem = this;

            this.Hide();

            _fForgetPassword.ShowDialog();

            _fForgetPassword = null;

            txtPassword.ResetText();

            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) == true)
            {
                errorProvider1.SetError(txtUsername, "Chưa điền Tên tài khoản");
                txtUsername.Focus();
                return;
            }

            errorProvider1.Clear();

            if (String.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider1.SetError(txtPassword, "Chưa điền Mật khẩu");
                txtPassword.Focus();
                return;
            }

            if (Check.CheckChar(txtUsername.Text) == false)
            {
                errorProvider1.SetError(txtUsername, "Không được chứa ký tự");
                txtUsername.ResetText();
                txtUsername.Focus();
                return;
            }

            if (Check.CheckChar(txtPassword.Text) == false)
            {
                errorProvider1.SetError(txtPassword, "Không được chứa ký tự");
                txtPassword.ResetText();
                txtPassword.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            if (Transfer.Trans.CheckLogin(txtUsername.Text, GraphicsUserInterface.GraphicsUsers.MaHoa(txtPassword.Text)) == true)
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _fSystem = new fSystem();

                _fSystem.FormLoginSystem = this;

                _fSystem._sUsername = txtUsername.Text;

                this.Hide();

                _fSystem.ShowDialog();

                _fSystem = null;

                txtPassword.ResetText();

                txtPassword.Focus();
            }
            else
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

            Bitmap _bm = new Bitmap(Properties.Resources.ShushiIcon);

            GraphicsUserInterface.GraphicsUsers.PaintPanel(_g, "Phần Mềm Quản Lý Quán Sushi", 38, 6, _bm);

            _bm.Dispose();

            _g.Dispose();
        }

        private void txtClick(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;

            if((sender as TextEdit).Text.Equals(string.Empty) == false)
            {
                (sender as TextEdit).SelectAll();
            }
        }

        private void ButtonTab(int _x, int _y, int _iWidth, int _iHeight)
        {
            btnTab.Size = new Size(_iWidth, _iHeight);
            btnTab.Location = new Point(_x, _y);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            ButtonTab(0, 142, 10, 34);
        }

        private void pnTitle_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fLoginSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                if (GraphicsUserInterface.GraphicsUsers.CloseMessage() == true)
                    Application.Exit();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            ButtonTab(0, 198, 10, 34);
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            ButtonTab(btnLogin.Location.X + 15, 310, 34, 10);
        }

        private void btnChangePassword_Enter(object sender, EventArgs e)
        {
            ButtonTab(btnChangePassword.Location.X + 15, 310, 34, 10);
        }

        private void btnForgetPassword_Enter(object sender, EventArgs e)
        {
            ButtonTab(btnForgetPassword.Location.X + 15, 310, 34, 10);
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = true;
        }
    }
}
