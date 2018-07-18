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
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.DoanhThu(gcDoanhThu, txtTongDoanhThu);
        }

        private void btnXuatExcelDoanhThu_Click(object sender, EventArgs e)
        {
            if (gvDoanhThu.DataRowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transfer.Trans.XuatExcelDoanhThu(gvDoanhThu, "Tổng Doanh Thu", "Tổng Tiển " + txtTongDoanhThu.Text);
        }
    }
}
