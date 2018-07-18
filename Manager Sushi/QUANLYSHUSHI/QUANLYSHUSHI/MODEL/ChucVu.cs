using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class ChucVu
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
    }
}
