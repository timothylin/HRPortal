using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Experience
    {
        public string Company { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Address Location { get; set; }
        public string Description { get; set; }
        public ContactInfo SupervisorInfo { get; set; }

        public Experience()
        {
            Location = new Address();
            SupervisorInfo = new ContactInfo();
        }
    }
}
