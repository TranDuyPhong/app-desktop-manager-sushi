using DevExpress.XtraEditors;
using QUANLYSHUSHI.BLL;
using QUANLYSHUSHI.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSHUSHI
{
    public partial class fForgetPassword : Form
    {
        private fLoginSystem _fLoginSystem = null;

        public fLoginSystem LoginSystem
        {
            get
            {
                return _fLoginSystem;
            }
            set
            {
                _fLoginSystem = value;
            }
        }

        public fForgetPassword()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            _fLoginSystem.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtEmail.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Gmail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            if(Transfer.Trans.GetPassWord(txtTaiKhoan.Text, txtEmail.Text) == true)
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Thành công" + "\n" + "Hãy kiểm tra Gmail của bạn để lấy Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _fLoginSystem.txtUsername.Text = txtTaiKhoan.Text;

                this.Close();

                _fLoginSystem.Show();
            }
            else
            {
                this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

                XtraMessageBox.Show("Tên tài khoản hoặc Gmail không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
