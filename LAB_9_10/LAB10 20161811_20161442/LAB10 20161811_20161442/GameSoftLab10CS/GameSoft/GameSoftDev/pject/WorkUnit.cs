using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class WorkUnit
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }


    }
}
