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
    public partial class UCMonAn : UserControl
    {
        private string _sMaThucAn = "";

        public UCMonAn()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            Transfer.Trans.Food(gcMonAn);

            BindingFood();

            txtTenThucAn.Focus();
        }

        private void BindingFood()
        {
            txtTenThucAn.DataBindings.Clear();
            txtTenThucAn.DataBindings.Add(new Binding("Text", gvMonAn.DataSource, "Name"));
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add(new Binding("Text", gvMonAn.DataSource, "Price"));
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtTenThucAn.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtTenThucAn, "Chưa nhập Tên thức ăn");
                txtTenThucAn.Focus();
                return;
            }

            if (txtGia.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtGia, "Chưa nhập Giá");
                txtGia.Focus();
                return;
            }

            if (Transfer.Trans.AddFood(txtTenThucAn.Text, Convert.ToSingle(txtGia.Text)) == true)
            {
                XtraMessageBox.Show("Thêm Thức ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcMonAn.DataSource = null;
                Transfer.Trans.Food(gcMonAn);
                BindingFood();
                txtTenThucAn.Focus();
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (gvMonAn.DataRowCount == 1)
            {
                _sMaThucAn = gvMonAn.GetRowCellValue(0, "ID").ToString();
            }

            errorProvider1.Clear();

            if (_sMaThucAn.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Thức ăn cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            errorProvider1.Clear();

            if (txtTenThucAn.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtTenThucAn, "Chưa nhập Tên thức ăn");
                txtTenThucAn.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txtGia.Text.Equals(string.Empty) == true)
            {
                errorProvider1.SetError(txtGia, "Chưa nhập Giá");
                txtGia.Focus();
                return;
            }

            if (Transfer.Trans.EditFood(_sMaThucAn, txtTenThucAn.Text, Convert.ToSingle(txtGia.Text)) == true)
            {
                XtraMessageBox.Show("Sửa Thức ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcMonAn.DataSource = null;
                Transfer.Trans.Food(gcMonAn);
                BindingFood();
                txtTenThucAn.Focus();
            }

            _sMaThucAn = "";
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (gvMonAn.DataRowCount == 1)
            {
                _sMaThucAn = gvMonAn.GetRowCellValue(0, "ID").ToString();
            }

            if (_sMaThucAn.Equals(string.Empty) == true)
            {
                XtraMessageBox.Show("Chưa chọn Thức ăn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn muốn xóa Món ăn này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Transfer.Trans.RemoveFood(_sMaThucAn) == true)
                {
                    XtraMessageBox.Show("Xóa Thức ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcMonAn.DataSource = null;
                    Transfer.Trans.Food(gcMonAn);
                    BindingFood();
                    txtTenThucAn.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Không xóa Thức ăn này được vì Thức ăn này đang có trong Bill Chưa thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _sMaThucAn = "";
        }

        private void btnQuayLaiThucAn_Click(object sender, EventArgs e)
        {
            Transfer.Trans.Food(gcMonAn);
        }

        private void gvMonAn_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
                _sMaThucAn = gvMonAn.GetFocusedRowCellValue("ID").ToString();
        }

        private void txtTimKiemMonAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && (sender as TextEdit).Equals(string.Empty) == false)
            {
                Transfer.Trans.TimKiemFood(gcMonAn, (sender as TextEdit).Text.Trim());
            }
        }
    }
}
