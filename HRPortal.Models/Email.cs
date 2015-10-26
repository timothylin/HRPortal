using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Email
    {
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public string EmailType { get; set; }

        public Email(string address, string type)
        {
            EmailAddress = address;
            EmailType = type;
        }
    }
}
