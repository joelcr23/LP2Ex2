using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Role
    {
        private string _title;
        private float _minSalary;
        private float _maxSalary;

        public string Title { get => _title; set => _title = value; }
        public float MinSalary { get => _minSalary; set => _minSalary = value; }
        public float MaxSalary { get => _maxSalary; set => _maxSalary = value; }
    }
}
