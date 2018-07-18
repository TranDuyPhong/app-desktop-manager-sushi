using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI
{
    public static class EmailUser
    {
        private static string _sUser;
 
        public static string User
        {
            get
            {
                return _sUser;
            }
            set
            {
                _sUser = value;
            }
        }

        private static string _sPass;

        public static string Pass
        {
            get
            {
                return _sPass;
            }
            set
            {
                _sPass = value;
            }
        }
    }
}
