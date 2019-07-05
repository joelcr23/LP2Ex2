using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _secondLastName;
        private string _DNI;
        private string _gender;
        private string _email;
        private DateTime _birthday;
        private DateTime _hireDate;
        private double _salary;
        private Role _role;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string SecondLastName { get => _secondLastName; set => _secondLastName = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public DateTime HireDate { get => _hireDate; set => _hireDate = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public Role Role { get => _role; set => _role = value; }
    }
}
