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
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI
{
    public partial class UCBaoCaoNgay : UserControl
    {
        public UCBaoCaoNgay()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.BaoCao("Ngày", gcBaoCaoNgay, dtpTimKiemBaoCaoNgay);
        }

        private void btnTimKiemBaoCaoNgay_Click(object sender, EventArgs e)
        {
            Transfer.Trans.BaoCao("Ngày", gcBaoCaoNgay, dtpTimKiemBaoCaoNgay);
        }

        private void btnXuatExcelNgay_Click(object sender, EventArgs e)
        {

        }
    }
}
