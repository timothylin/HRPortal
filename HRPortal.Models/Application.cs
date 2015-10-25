using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Application
    {
        public int AppId { get; set; }

        public ContactInfo ApplicantContactInfo { get; set; }
        public Position Position { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<EducationInfo> Education { get; set; }
        public int DesiredSalary { get; set; }

        [DataType(DataType.Date)]
        public DateTime AppDate { get; set; }

        public Application()
        {
            ApplicantContactInfo = new ContactInfo();
            Position = new Position();
            Experiences = new List<Experience>();
            Education = new List<EducationInfo>();
            AppDate = DateTime.Now;
        }

    }
}
