using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI
{
    public static class ForgetPassword
    {
        private static string _sPassword;

        public static string Password
        {
            get
            {
                return _sPassword;
            }
            set
            {
                _sPassword = value;
            }
        }
    }
}
