using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class PhoneNumber
    {
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }

        public PhoneNumber(string phone, PhoneType type)
        {
            Number = phone;
            PhoneType = type;
        }
    }
}
