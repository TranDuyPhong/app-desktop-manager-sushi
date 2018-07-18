using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class LuongTam
    {
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

        private float _fLuong;

        public float Luong
        {
            get
            {
                return _fLuong;
            }
            set
            {
                _fLuong = value;
            }
        }
    }
}
