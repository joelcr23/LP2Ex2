using GameSoftSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Participant : Resource 
    {
        private User _user;
        private String _fullName;

        public String FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private DateTime _signupDate;

        public DateTime SignupDate
        {
            get { return _signupDate; }
            set { _signupDate = value; }
        }

    }
}
