using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class NhanVien
    {
        private string _sId;

        public string ID
        {
            get { return _sId;}
            set{_sId = value;}
        }

        private string _sName;

        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }

        private string _sPhone;

        public string Phone
        {
            get { return _sPhone; }
            set { _sPhone = value; }
        }

        private string _sEmail;

        public string Email
        {
            get { return _sEmail; }
            set { _sEmail = value; }
        }

        private bool _sSex;

        public bool Sex
        {
            get { return _sSex; }
            set { _sSex = value; }
        }

        private string _sBrithday;

        public string Brithday
        {
            get { return _sBrithday; }
            set { _sBrithday = value; }
        }

        private float _sLuong;

        public float Luong
        {
            get { return _sLuong; }
            set { _sLuong = value; }
        }

        private string _sIdChucVu;

        public string IDChucVu
        {
            get { return _sIdChucVu; }
            set { _sIdChucVu = value; }
        }
    }
}
