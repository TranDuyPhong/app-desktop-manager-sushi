using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSHUSHI.BLL;
using QUANLYSHUSHI.DAO;
using QUANLYSHUSHI.MODEL;
using QUANLYSHUSHI.GUI;

namespace QUANLYSHUSHI
{
    public partial class fThucDon : Form
    {
        public List<Food> _listFood = null;
        public fSystem _f = null;
        public List<Food> _listThucDon = null;

        public fThucDon()
        {
            InitializeComponent();

            this.Cursor = GraphicsUserInterface.GraphicsUsers.MouseHand(Properties.Resources.HandMouse1);

            LoadFood();

            lbMonAn.Focus();
        }

        private void LoadFood()
        {
            _listFood = GetData.Get.Food();

            lbMonAn.DataSource = _listFood;

            lbMonAn.DisplayMember = "Name";

            lbMonAn.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _listFood = null;

            this.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int _k = 0;

            if(lbMonAn.SelectedIndices.Count > 0)
            {
                for(int _i = 0; _i < lbMonAn.SelectedIndices.Count; _i++)
                {
                    _k = 0;

                    for(int _j = 0; _j < _listThucDon.Count(); _j++)
                    {
                        if(_listFood[lbMonAn.SelectedIndices[_i]].Name.ToString().CompareTo(_listThucDon[_j].Name) == 0)
                        {
                            _k = 1;
                        }

                        if(_k == 1)
                        {
                            break;
                        }
                    }

                    if(_k == 0)
                    {
                        Food _f = new Food() { ID = _listFood[lbMonAn.SelectedIndices[_i]].ID, Name = _listFood[lbMonAn.SelectedIndices[_i]].Name, Price = _listFood[lbMonAn.SelectedIndices[_i]].Price };
                        _listThucDon.Add(_f);
                        _f = null;
                        lbThucDonHienTai.DataSource = null;
                        lbThucDonHienTai.DataSource = _listThucDon;
                        lbThucDonHienTai.DisplayMember = "Name";
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _f.dgvThucDon.Rows.Clear();

            int _i = 0;

            foreach(Food _food in _listThucDon)
            {
                _f.dgvThucDon.Rows.Add();

                _f.dgvThucDon["ID", _i].Value = _food.ID;
                _f.dgvThucDon["Name", _i].Value = _food.Name;
                _f.dgvThucDon["Price", _i].Value = _food.Price;
                _f.dgvThucDon["SoLuong", _i].Value = 0;

                _i++;
            }

            _f._listFoodThucDon = null;

            _f._listFoodThucDon = _listThucDon;

            _listFood = null;

            _listThucDon = null;

            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbThucDonHienTai.SelectedIndices.Count > 0)
            {
                int _k = lbThucDonHienTai.SelectedIndices.Count;

                for(int _i = 0; _i < _k; _i++)
                {
                    for (int _j = 0; _j < _listThucDon.Count(); _j++)
                    {
                        if(_listThucDon[_j].Name.Contains((lbThucDonHienTai.SelectedItems[0] as Food).Name.ToString()) == true)
                        {
                            _listThucDon.RemoveAt(_j);

                            break;
                        }
                    }
                }

                lbThucDonHienTai.DataSource = null;
                lbThucDonHienTai.DataSource = _listThucDon;
                lbThucDonHienTai.DisplayMember = "Name";
            }
        }

        private void fThucDon_Load(object sender, EventArgs e)
        {
            lbThucDonHienTai.DataSource = _listThucDon;
            lbThucDonHienTai.DisplayMember = "Name";
        }

        private void pnTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics _g = e.Graphics;

             Bitmap _bm = new Bitmap(Properties.Resources.ShushiIcon);

             GraphicsUserInterface.GraphicsUsers.PaintPanel(_g, "Thay đổi Thực đơn", 38, 6, _bm);
        
            _g.Dispose();

            _bm.Dispose();
        }
    }
}
