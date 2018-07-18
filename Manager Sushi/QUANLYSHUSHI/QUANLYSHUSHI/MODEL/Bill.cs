using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class Bill
    {
        private string _sId;

        public string ID
        {
            get { return _sId; }
            set { _sId = value; }
        }

        private string _sThoiGianLap;

        public string ThoiGianLap
        {
            get { return _sThoiGianLap; }
            set { _sThoiGianLap = value; }
        }

        private string _sThoiGianXuat;

        public string ThoiGianXuat
        {
            get { return _sThoiGianXuat; }
            set { _sThoiGianXuat = value; }
        }

        private float _fTongTien;

        public float TongTien
        {
            get { return _fTongTien; }
            set { _fTongTien = value; }
        }

        private string _sIdBan;

        public string IDBan
        {
            get { return _sIdBan; }
            set { _sIdBan = value; }
        }
    }
}
