using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class LuongNhanVien
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

        private string _sChuThich;

        public string ChuThich
        {
            get
            {
                return _sChuThich;
            }
            set
            {
                _sChuThich = value;
            }
        }
    }
}
