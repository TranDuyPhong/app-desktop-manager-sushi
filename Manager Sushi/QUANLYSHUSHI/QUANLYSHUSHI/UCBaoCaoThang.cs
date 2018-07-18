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
    public partial class UCBaoCaoThang : UserControl
    {
        public UCBaoCaoThang()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.BaoCao("Tháng", gcBaoCaoThang, dtpTimKiemBaoCaoTheoThang);
        }

        private void btnTimKiemBaoCaoTheoThang_Click(object sender, EventArgs e)
        {
            Transfer.Trans.BaoCao("Tháng", gcBaoCaoThang, dtpTimKiemBaoCaoTheoThang);
        }

        private void btnXuatExcelThang_Click(object sender, EventArgs e)
        {

        }
    }
}
