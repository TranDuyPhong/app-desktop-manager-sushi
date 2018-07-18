using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class DoanhThu
    {
        private int _iStt;

        public int STT
        {
            get
            {
                return _iStt;
            }
            set
            {
                _iStt = value;
            }
        }
       
        private string _sNgay;

        public string Ngay
        {
            get
            {
                return _sNgay;
            }
            set
            {
                _sNgay = value;
            }
        }

        private float _sTongTien;

        public float TongTien
        {
            get
            {
                return _sTongTien;
            }
            set
            {
                _sTongTien = value;
            }
        }
    }
}
