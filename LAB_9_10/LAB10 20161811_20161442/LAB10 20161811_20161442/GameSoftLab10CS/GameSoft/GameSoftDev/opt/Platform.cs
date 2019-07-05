using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.opt
{
    public class Platform
    {
        private int _id;
        private string _name;
        private bool _active;

        public Platform() { }

        public Platform(string name)
        {
            _name = name;
            _active = true;
        }

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Active { get => _active; set => _active = value; }
    }
}
