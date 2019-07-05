using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Time : Resource    
    {
        private String _measureUnit;

        public String MeasureUnit
        {
            get { return _measureUnit; }
            set { _measureUnit = value; }
        }

        private float _quantity;

        public float Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

    }
}
