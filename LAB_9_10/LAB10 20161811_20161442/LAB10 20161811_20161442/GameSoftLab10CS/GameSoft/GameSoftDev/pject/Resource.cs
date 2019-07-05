using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Resource
    {
        private string _name;

        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }


    }
}
