using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class RoleHistory
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private Role _role;
        private Employee _employee;
        private Department _department;

        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public Role Role { get => _role; set => _role = value; }
        public Employee Employee { get => _employee; set => _employee = value; }
        public Department Department { get => _department; set => _department = value; }
    }
}
