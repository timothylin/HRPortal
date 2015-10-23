using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string Zipcode { get; set; }
        public string AddressType { get; set; }

        public Address()
        {
            State = new State();
        }
    }
}
