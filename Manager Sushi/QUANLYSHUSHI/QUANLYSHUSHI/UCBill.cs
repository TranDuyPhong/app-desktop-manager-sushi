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
    public partial class UCBill : UserControl
    {
        public UCBill()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.Bill(gcBill);

            cbbSoBan.Focus();
        }

        private void btnBillChuaThanhToan_Click(object sender, EventArgs e)
        {
            Transfer.Trans.BillSort("Chưa Thanh Toán", gcBill);
        }

        private void btnBillDaThanhToan_Click(object sender, EventArgs e)
        {
            Transfer.Trans.BillSort("Đã Thanh Toán", gcBill);
        }

        private void btnTatCaBill_Click(object sender, EventArgs e)
        {
            Transfer.Trans.Bill(gcBill);
        }

        private void btnXuatExcelBill_Click(object sender, EventArgs e)
        {
            if (gvBill.DataRowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float _fTongTien = 0f;

            for (int _i = 0; _i < gvBill.DataRowCount; _i++)
            {
                _fTongTien += Convert.ToSingle(gvBill.GetRowCellValue(_i, "TongTien"));
            }

            Transfer.Trans.XuatExcelDoanhThu(gvBill, "Danh Sách Bill", "Tổng Tiền " + _fTongTien.ToString());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Transfer.Trans.TimKiemBill(cbbSoBan, dtpTimKiem, timeBill, gcBill);
        }
    }
}
