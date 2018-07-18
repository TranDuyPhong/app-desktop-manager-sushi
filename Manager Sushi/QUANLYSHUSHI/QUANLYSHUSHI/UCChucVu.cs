using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYSHUSHI.BLL;
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI
{
    public partial class UCChucVu : UserControl
    {
        private string _sMaChucVu = "";

        public UCChucVu()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.ChucVu(gcChucVu);

            BindingChucVu();

            txtChucVu.Focus();
        }

        private void BindingChucVu()
        {
            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add(new Binding("Text", gvChucVu.DataSource, "Name"));
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            if (txtChucVu.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa nhập Tên chức vụ cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.CheckThemSuaChucVu(txtChucVu.Text) == true)
            {
                XtraMessageBox.Show("Đã có Chức vụ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.ThemChucVu(txtChucVu.Text) == true)
            {
                XtraMessageBox.Show("Thêm Chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.ChucVu(gcChucVu);
            }
        }

        private void btnSuaChucVu_Click(object sender, EventArgs e)
        {
            if (gvChucVu.DataRowCount == 1)
            {
                _sMaChucVu = gvChucVu.GetRowCellValue(0, "ID").ToString();
            }

            if (_sMaChucVu.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Chức vụ cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.CheckThemSuaChucVu(txtChucVu.Text) == true)
            {
                XtraMessageBox.Show("Đã có Chức vụ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.SuaChucVu(_sMaChucVu, txtChucVu.Text) == true)
            {
                XtraMessageBox.Show("Sửa Chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.ChucVu(gcChucVu);

                Transfer.Trans.DoubleClickChucVu(_sMaChucVu, gcDanhSachNhanVienTheoChucVu);
            }

            _sMaChucVu = "";
        }

        private void btnXoaChucVu_Click(object sender, EventArgs e)
        {
            if (gvChucVu.DataRowCount == 1)
            {
                _sMaChucVu = gvChucVu.GetRowCellValue(0, "ID").ToString();
            }

            if (_sMaChucVu.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Chức vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.CheckXoaChucVu(_sMaChucVu) == true)
            {
                XtraMessageBox.Show("Đang có Nhân viên đang giữ Chức vụ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Transfer.Trans.XoaChucVu(_sMaChucVu) == true)
            {
                XtraMessageBox.Show("Xóa Chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Transfer.Trans.ChucVu(gcChucVu);
            }

            _sMaChucVu = "";
        }

        private void gvChucVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
                _sMaChucVu = gvChucVu.GetFocusedRowCellValue("ID").ToString();
        }

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            if (gvChucVu.GetSelectedRows().Count() > 0)
            {
                _sMaChucVu = gvChucVu.GetRowCellValue(gvChucVu.GetSelectedRows()[0], "ID").ToString();

                Transfer.Trans.DoubleClickChucVu(_sMaChucVu, gcDanhSachNhanVienTheoChucVu);
            }

            _sMaChucVu = "";
        }
    }
}
