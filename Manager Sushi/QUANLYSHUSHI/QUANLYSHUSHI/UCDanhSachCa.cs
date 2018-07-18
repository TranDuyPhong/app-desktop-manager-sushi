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
    public partial class UCDanhSachCa : UserControl
    {
        private string _sMaCa = "";
        private string _sMaNhanVien = "";
        private string _sMaNV = "";

        public UCDanhSachCa()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            LayNgayHienTai(cbbThu);

            Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);

            Transfer.Trans.LoadNhanVienComboBox(cbbNhanVien);
        }

        private void LayNgayHienTai(ComboBoxEdit _cbb)
        {
            string[] _sArrayThu = new string[7] { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy", "Chủ nhật" };

            _cbb.Properties.Items.AddRange(_sArrayThu);

            int _i = (int)DateTime.Now.DayOfWeek;

            if (_i == 0)
            {
                _cbb.SelectedIndex = 6;

                return;
            }

            _cbb.SelectedIndex = _i - 1;
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            if(nudGioLam.Value == nudGioKetThuc.Value && nudPhutLam.Value == nudPhutKetThuc.Value)
            {
                XtraMessageBox.Show("Giờ làm và giờ kết thúc trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(nudGioLam.Value > nudGioKetThuc.Value)
            {
                XtraMessageBox.Show("Giờ làm phải nhỏ hơn Giờ kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_sMaNV.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _sGioLam = nudGioLam.Value.ToString() + ":" + nudPhutLam.Value.ToString();
            string _sGioKetThuc = nudGioKetThuc.Value.ToString() + ":" + nudPhutKetThuc.Value.ToString();

            int _i = Transfer.Trans.ThemCa(cbbThu.Text, _sGioLam, _sGioKetThuc, _sMaNV);

            if(_i == -1)
            {
                XtraMessageBox.Show("Thao tác Thêm Ca không được thực hiện vào ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(_i == 0)
            {
                XtraMessageBox.Show("Nhân viên bạn muốn Thêm Ca đã có Ca này trong Danh sách ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(_i == 1)
            {
                XtraMessageBox.Show("Thêm Ca thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);
            }
        }

        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            if(gvDanhSachCa.DataRowCount == 1)
            {
                _sMaCa = gvDanhSachCa.GetRowCellValue(0, "ID").ToString();
            }

            if(_sMaCa.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Ca cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_sMaNV.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(nudGioLam.Value == nudGioKetThuc.Value && nudPhutLam.Value == nudPhutKetThuc.Value)
            {
                XtraMessageBox.Show("Giờ làm trùng Giờ kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(nudGioLam.Value > nudGioKetThuc.Value)
            {
                XtraMessageBox.Show("Giờ làm không được lớn hơn Giờ kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _sGioLam = nudGioLam.Value.ToString() + ":" + nudPhutLam.Value.ToString();
            string _sGioKetThuc = nudGioKetThuc.Value.ToString() + ":" + nudPhutKetThuc.Value.ToString();

            if(XtraMessageBox.Show("Bạn chắc chắn muốn sửa Ca này chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int _i = Transfer.Trans.EditCa(_sMaCa, _sMaNV, _sGioLam, _sGioKetThuc, cbbThu.Text);

                if(_i == 1)
                {
                     XtraMessageBox.Show("Sửa Ca thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);
                }
                else if(_i == -1)
                {
                    XtraMessageBox.Show("Thao tác sửa Ca không được thực hiện vào ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(_i == 0)
                {
                    XtraMessageBox.Show("Ca muốn sửa bị trùng trong Danh sách ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _sMaCa = "";
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCa.DataRowCount == 1)
            {
                _sMaCa = gvDanhSachCa.GetRowCellValue(0, "ID").ToString();
                _sMaNhanVien = gvDanhSachCa.GetRowCellValue(0, "IDNhanVien").ToString();
            }

            if(_sMaCa.Equals(string.Empty) == true || _sMaNhanVien.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Ca muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Ca này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(Transfer.Trans.RemoveCa(_sMaCa, _sMaNhanVien, cbbThu.Text) == true)
                {
                    XtraMessageBox.Show("Xóa Ca thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);
                }
                else
                {
                    XtraMessageBox.Show("Thao tác Xóa ca không được thực hiện vào ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _sMaCa = "";
            _sMaNhanVien = "";
        }

        private void cbbThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);
        }

        private void gvDanhSachCa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                _sMaCa = gvDanhSachCa.GetRowCellValue(e.FocusedRowHandle, "ID").ToString();
                _sMaNhanVien = gvDanhSachCa.GetRowCellValue(e.FocusedRowHandle, "IDNhanVien").ToString();

                if (gvDanhSachCa.GetRowCellValue(e.FocusedRowHandle, "CheckCa").ToString().Equals("True", StringComparison.CurrentCultureIgnoreCase) == true)
                    ceCheckCa.Checked = true;
                else
                    ceCheckCa.Checked = false;

                string _sLam = gvDanhSachCa.GetRowCellValue(e.FocusedRowHandle, "GioLam").ToString();
                nudGioLam.Value = Convert.ToDecimal(_sLam.Substring(0, _sLam.IndexOf(':')));
                nudPhutLam.Value = Convert.ToDecimal(_sLam.Substring(_sLam.IndexOf(':') + 1));

                _sLam = gvDanhSachCa.GetRowCellValue(e.FocusedRowHandle, "GioKetThuc").ToString();
                nudGioKetThuc.Value = Convert.ToDecimal(_sLam.Substring(0, _sLam.IndexOf(':')));
                nudPhutKetThuc.Value = Convert.ToDecimal(_sLam.Substring(_sLam.IndexOf(':') + 1));
            }
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            if(_sMaCa.Equals(string.Empty) == true || _sMaNhanVien.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Ca của Nhân viên muốn điểm danh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Transfer.Trans.DiemDanh(_sMaCa, ceCheckCa.Checked, cbbThu.Text, _sMaNhanVien, "") == true)
            {
                XtraMessageBox.Show("Điểm danh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.DanhSachCa(cbbThu.Text, gcDanhSachCa);
            }

            _sMaCa = "";
            _sMaNhanVien = "";
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox _cbb = sender as System.Windows.Forms.ComboBox;

            if (_cbb.SelectedValue != null)
                _sMaNV = (_cbb.SelectedValue as NhanVien).ID.ToString();
        }
    }
}
