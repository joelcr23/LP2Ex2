using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Money : Resource   
    {
        private String _currency;

        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private float _quantity;

        public float Quantity   
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

    }
}
