using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHUSHI.MODEL
{
    public class Food
    {
        private string _sId;

        public string ID
        {
            get { return _sId; }
            set { _sId = value; }
        }

        private string _sName;

        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }

        private float _sPrice;

        public float Price
        {
            get { return _sPrice; }
            set { _sPrice = value; }
        }
    }
}
