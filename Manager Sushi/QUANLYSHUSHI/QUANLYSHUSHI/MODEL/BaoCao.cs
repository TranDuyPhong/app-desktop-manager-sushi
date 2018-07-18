using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class BaoCao
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

        private string _sName;

        public string Name
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
            }
        }

        private int _iSoLuong;

        public int SoLuong
        {
            get
            {
                return _iSoLuong;
            }
            set
            {
                _iSoLuong = value;
            }
        }

        private float _fTongTien;

        public float TongTien
        {
            get
            {
                return _fTongTien;
            }
            set
            {
                _fTongTien = value;
            }
        }
    }
}
