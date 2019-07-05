using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftRRHH
{
    public class Location
    {
        private string _address;
        private string _postalCode;
        private string _city;
        private string _province;
        private Country _country;

        public string Address { get => _address; set => _address = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string City { get => _city; set => _city = value; }
        public string Province { get => _province; set => _province = value; }
        public Country Country { get => _country; set => _country = value; }
    }
}
