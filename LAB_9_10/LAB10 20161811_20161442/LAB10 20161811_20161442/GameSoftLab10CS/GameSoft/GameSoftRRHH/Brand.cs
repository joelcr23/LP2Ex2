using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Brand
    {
        private string _name;
        private BindingList<Studio> _studios;
        private Location _location;

        public string Name { get => _name; set => _name = value; }
        public BindingList<Studio> Studios { get => _studios; set => _studios = value; }
        public Location Location { get => _location; set => _location = value; }
    }
}
