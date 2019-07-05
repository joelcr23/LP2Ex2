using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.opt
{
    public class ContentClassificationSystem
    {
        private int _id;
        private string _acronym;
        private string _description;
        private bool _active;

        public ContentClassificationSystem() { }

        public ContentClassificationSystem(string acronym, string description)
        {
            _description = description;
            _acronym = acronym;
            _active = true;
        }

        public string Description { get => _description; set => _description = value; }
        public int Id { get => _id; set => _id = value; }
        public string Acronym { get => _acronym; set => _acronym = value; }
        public bool Active { get => _active; set => _active = value; }
    }
}
