using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class CaNghi
    {
        private string _sNgayNghi;

        public string NgayNghi
        {
            get
            {
                return _sNgayNghi;
            }
            set
            {
                _sNgayNghi = value;
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

        private string _sIDNhanVien;

        public string IDNhanVien
        {
            get
            {
                return _sIDNhanVien;
            }
            set
            {
                _sIDNhanVien = value;
            }
        }
    }
}
