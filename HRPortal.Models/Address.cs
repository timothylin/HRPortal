using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string StateAbbr { get; set; }

        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }
    }
}
