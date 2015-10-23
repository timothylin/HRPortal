using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class ContactInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }

        public Email Email { get; set; }
        public PhoneNumber Phone { get; set; }
        public Address Address { get; set; }
    }
}
