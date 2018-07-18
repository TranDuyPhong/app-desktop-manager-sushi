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
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI
{
    public partial class UCLuongNhanVien : UserControl
    {
        private string _sMaNhanVien = "";

        public UCLuongNhanVien()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.LuongNhanVien(gcLuongNhanVien);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(_sMaNhanVien.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên cần Set Lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtLuong.Text.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa Set Lương cho Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Transfer.Trans.SetLuongTam(_sMaNhanVien, txtLuong.Text) == true)
            {
                XtraMessageBox.Show("Set Lương cho Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLuong.Text = Transfer.Trans.LuongTam(_sMaNhanVien).ToString();
            }
        }

        private void gvLuongNhanVien_Click(object sender, EventArgs e)
        {
            if(gvLuongNhanVien.GetSelectedRows().Count() > 0)
            {
                Transfer.Trans.DanhSachNgayNghi(gvLuongNhanVien.GetRowCellValue(gvLuongNhanVien.GetSelectedRows()[0], "ID").ToString(), gcNgayNghi);
                _sMaNhanVien = gvLuongNhanVien.GetRowCellValue(gvLuongNhanVien.GetSelectedRows()[0], "ID").ToString();
                txtLuong.Text = Transfer.Trans.LuongTam(_sMaNhanVien).ToString();
            }
        }

        private void btnXuatExcelLuongNhanVien_Click(object sender, EventArgs e)
        {
            if(gvLuongNhanVien.GetSelectedRows().Count() <= 0)
            {
                XtraMessageBox.Show("Chưa chọn Nhân viên để xuất Excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(gvLuongNhanVien.GetSelectedRows().Count() >= 2)
            {
                XtraMessageBox.Show("Chỉ chọn lần lượt một Nhân viên để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transfer.Trans.XuatExcelLuongNhanVien(gvLuongNhanVien, gvNgayNghi);
        }
    }
}
