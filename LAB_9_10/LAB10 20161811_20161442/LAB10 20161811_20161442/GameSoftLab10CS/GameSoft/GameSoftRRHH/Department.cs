using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Department
    {
        private string _name;
        private BindingList<Employee> _employees;
        private Employee _manager;
        private BindingList<Department> _departments;

        public string Name { get => _name; set => _name = value; }
        public BindingList<Employee> Employees { get => _employees; set => _employees = value; }
        public Employee Manager { get => _manager; set => _manager = value; }
        public BindingList<Department> Departments { get => _departments; set => _departments = value; }
    }
}
