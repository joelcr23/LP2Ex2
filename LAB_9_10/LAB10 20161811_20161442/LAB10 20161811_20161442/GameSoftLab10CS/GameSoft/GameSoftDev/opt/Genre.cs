using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.opt
{
    public class Genre
    {
        private int _id;
        private string _name;
        private bool _active;

        public Genre() { }

        public Genre(string name)
        {
            _name = name;
            _active = true;
        }

        public Genre(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public bool Active { get => _active; set => _active = value; }
    }
}
