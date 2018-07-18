using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class BillFood
    {
        private string _sIdBill;

        public string IDBill
        {
            get { return _sIdBill; }
            set { _sIdBill = value; }
        }

        private string _sIdFood;

        public string IDFood
        {
            get { return _sIdFood; }
            set { _sIdFood = value; }
        }

        private string _sNameFood;

        public string NameFood
        {
            get { return _sNameFood; }
            set { _sNameFood = value; }
        }

        private float _fGia;

        public float Gia
        {
            get { return _fGia; }
            set { _fGia = value; }
        }

        private byte _bSoLuong;

        public byte SoLuong
        {
            get { return _bSoLuong; }
            set { _bSoLuong = value; }
        }

        private float _fThanhTien;

        public float ThanhTien
        {
            get { return _fThanhTien; }
            set { _fThanhTien = value; }
        }

        private string _sIdBan;

        public string IDBan
        {
            get { return _sIdBan; }
            set { _sIdBan = value; }
        }
    }
}
