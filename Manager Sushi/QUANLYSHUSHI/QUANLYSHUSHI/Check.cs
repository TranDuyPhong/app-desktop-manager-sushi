using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QUANLYSHUSHI
{
    public static class Check
    {
        private static Regex _regex = null;

        public static bool CheckChar(params string[] _sArray)
        {
            _regex = new Regex(@"\W");

            for(int _i = 0; _i < _sArray.Length; _i++)
            {
                if(_regex.IsMatch(_sArray[_i]) == true)
                {
                    _regex = null;

                    return false;
                }
            }

            _regex = null;

            return true;
        }

        public static bool CheckNumber(params string[] _sArray)
        {
            _regex = new Regex(@"\D");

            for (int _i = 0; _i < _sArray.Length; _i++)
            {
                if(_regex.IsMatch(_sArray[_i]) == true)
                {
                    _regex = null;

                    return false;
                }
            }

            _regex = null;

            return true;
        }
    }
}
