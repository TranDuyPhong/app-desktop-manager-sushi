using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class DanhSachCa
    {
        private string _sId;

        public string ID
        {
            get
            {
                return _sId;
            }
            set
            {
                _sId = value;
            }
        }

        private string _sThu;

        public string Thu
        {
            get
            {
                return _sThu;
            }
            set
            {
                _sThu = value;
            }
        }

        private string _sGioLam;

        public string GioLam
        {
            get
            {
                return _sGioLam;
            }
            set
            {
                _sGioLam = value;
            }
        }

        private string _sGioKetThuc;

        public string GioKetThuc
        {
            get
            {
                return _sGioKetThuc;
            }
            set
            {
                _sGioKetThuc = value;
            }
        }

        private bool _bCheckCa;

        public bool CheckCa
        {
            get
            {
                return _bCheckCa;
            }
            set
            {
                _bCheckCa = value;
            }
        }

        private string _sIdNhanVien;

        public string IDNhanVien
        {
            get
            {
                return _sIdNhanVien;
            }
            set
            {
                _sIdNhanVien = value;
            }
        }
    }
}
