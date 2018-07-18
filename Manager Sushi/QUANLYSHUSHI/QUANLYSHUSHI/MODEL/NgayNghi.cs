using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class NgayNghi
    {
        private string _sNgayNghi;

        public string Ngay
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
