using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Country
    {
        private string _name;
        private Region _region;

        public string Name { get => _name; set => _name = value; }
        public Region Region { get => _region; set => _region = value; }
    }
}
