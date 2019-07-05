using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Studio
    {
        private string _name;
        private BindingList<Department> _departments;

        public Studio(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public BindingList<Department> Departments { get => _departments; set => _departments = value; }
    }
}
