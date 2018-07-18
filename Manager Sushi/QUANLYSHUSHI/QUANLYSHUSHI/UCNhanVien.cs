using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSHUSHI.BLL;
using DevExpress.XtraEditors;
using QUANLYSHUSHI.MODEL;
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI
{
    public partial class UCNhanVien : UserControl
    {
        private string _sMaChucVu = "";
        private string _sMaNhanVien = "";

        public UCNhanVien()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.NhanVien(gcNhanVien);

            Transfer.Trans.ChucVuComboBox(cbbChucVu);

            BindingNhanVien();

            txtTenNhanVien.Focus();
        }

        private void BindingNhanVien()
        {
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add(new Binding("Text", gvNhanVien.DataSource, "Name"));
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add(new Binding("Text", gvNhanVien.DataSource, "Phone"));
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add(new Binding("Text", gvNhanVien.DataSource, "Email"));
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add(new Binding("Text", gvNhanVien.DataSource, "Luong"));
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Equals("") == true)
            {
                errorProvider1.SetError(txtTenNhanVien, "Chưa nhập Tên nhân viên");
                txtTenNhanVien.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtSoDienThoai.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtSoDienThoai, "Chưa nhập Số điện thoại");
                txtSoDienThoai.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtEmail.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtEmail, "Chưa nhập Email");
                txtEmail.Focus();
                return;
            }

            errorProvider1.Clear();

            if (cbNam.Checked == false && cbNu.Checked == false)
            {
                errorProvider1.SetError(cbNu, "Chưa chọn Giới tính");
                return;
            }

            errorProvider1.Clear();

            if (dtpNgaySinh.Value.Month > DateTime.Now.Month && dtpNgaySinh.Value.Year > DateTime.Now.Year)
            {
                errorProvider1.SetError(dtpNgaySinh, "Ngày sinh không được lớn hơn ngày hiện tại");
                return;
            }

            errorProvider1.Clear();

            if (txtLuong.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtLuong, "Chưa nhập Lương");
                txtLuong.Focus();
                return;
            }

            errorProvider1.Clear();

            if (_sMaChucVu.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(cbbChucVu, "Chưa chọn Chức vụ");
                cbbChucVu.Focus();
                return;
            }

            errorProvider1.Clear();

            if (Transfer.Trans.AddNhanVien(txtTenNhanVien.Text, txtSoDienThoai.Text, txtEmail.Text, cbNam.Checked ? true : false, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), Convert.ToSingle(txtLuong.Text), _sMaChucVu) == true)
            {
                XtraMessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcNhanVien.DataSource = null;
                Transfer.Trans.NhanVien(gcNhanVien);
                BindingNhanVien();
                txtTenNhanVien.Focus();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.DataRowCount == 1)
            {
                _sMaNhanVien = gvNhanVien.GetRowCellValue(0, "ID").ToString();
            }

            if (_sMaNhanVien.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhanVien.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtTenNhanVien.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtTenNhanVien, "Chưa nhập Tên nhân viên");
                txtTenNhanVien.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtSoDienThoai.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtSoDienThoai, "Chưa nhập Số điện thoại");
                txtTenNhanVien.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtEmail.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtEmail, "Chưa nhập Email");
                txtTenNhanVien.Focus();
                return;
            }

            errorProvider1.Clear();

            if (cbNam.Checked == false && cbNu.Checked == false)
            {
                errorProvider1.SetError(cbNu, "Chưa chọn Giới tính");
                return;
            }

            errorProvider1.Clear();

            if (txtLuong.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtLuong, "Chưa nhập Lương");
                txtTenNhanVien.Focus();
                return;
            }

            if (_sMaChucVu.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(cbbChucVu, "Chưa chọn Chức vụ");
                cbbChucVu.Focus();
                return;
            }

            if (Transfer.Trans.EditNhanVien(_sMaNhanVien, txtTenNhanVien.Text, txtSoDienThoai.Text, txtEmail.Text, cbNam.Checked == true ? true : false, dtpNgaySinh.Value.ToString("dd/MM/yyyy"), Convert.ToSingle(txtLuong.Text), _sMaChucVu) == true)
            {
                XtraMessageBox.Show("Sửa Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcNhanVien.DataSource = null;
                Transfer.Trans.NhanVien(gcNhanVien);
                BindingNhanVien();
                txtTenNhanVien.Focus();
            }

            _sMaNhanVien = "";
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.DataRowCount == 1)
            {
                _sMaNhanVien = gvNhanVien.GetRowCellValue(0, "ID").ToString();
            }

            if (_sMaNhanVien.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.RemoveNhanVien(_sMaNhanVien) == true)
            {
                XtraMessageBox.Show("Xóa Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcNhanVien.DataSource = null;
                Transfer.Trans.NhanVien(gcNhanVien);
                BindingNhanVien();
                txtTenNhanVien.Focus();
            }

            _sMaNhanVien = "";
        }

        private void btnQuayLaiNhanVien_Click(object sender, EventArgs e)
        {
            Transfer.Trans.NhanVien(gcNhanVien);
        }

        private void txtTimKiemNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && (sender as TextEdit).Text.Equals(string.Empty) == false)
            {
                Transfer.Trans.TimKiemNhanVien(gcNhanVien, (sender as TextEdit).Text.Trim());
            }
        }

        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                _sMaNhanVien = gvNhanVien.GetFocusedRowCellValue("ID").ToString();

                cbNam.Checked = false;
                cbNu.Checked = false;

                if (gvNhanVien.GetFocusedRowCellValue("Sex").ToString().Equals("True") == true)
                {
                    cbNam.Checked = true;
                }
                else
                {
                    cbNu.Checked = true;
                }

                dtpNgaySinh.Value = Convert.ToDateTime(gvNhanVien.GetFocusedRowCellValue("Brithday").ToString());
            }
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            cbNu.Checked = false;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            cbNam.Checked = false;
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox _cbb = sender as System.Windows.Forms.ComboBox;

            if (_cbb.SelectedValue != null)
                _sMaChucVu = (_cbb.SelectedValue as ChucVu).ID.ToString();
        }
    }
}
