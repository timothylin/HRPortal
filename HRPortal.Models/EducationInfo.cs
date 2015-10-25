using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class EducationInfo
    {
        public Degree Degree { get; set; }
        public string Institution { get; set; }
        public Address Location { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? GraduationDate { get; set; }
        public decimal? GPA { get; set; }
        public string Concentration { get; set; }

        public EducationInfo()
        {
            Degree = new Degree();
            Location = new Address();
        }
    }
}
