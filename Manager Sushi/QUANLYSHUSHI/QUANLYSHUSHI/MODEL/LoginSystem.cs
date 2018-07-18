using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class LoginSystem
    {
        private string _sId;

        public string ID
        {
            get { return _sId; }
            set { _sId = value; }
        }

        private string _sPass;

        public string Pass
        {
            get{ return _sPass; }
            set{ _sPass =value; }
        }

        private string _sEmail;

        public string Email
        {
            get { return _sEmail; }
            set { _sEmail = value; }
        }
    }
}
