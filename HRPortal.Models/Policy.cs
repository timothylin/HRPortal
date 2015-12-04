using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }
        [Required]
        public string Title { get; set; }
        public PolicyCategory Category { get; set; }
        [Required]
        public string ContentText { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public Policy()
        {
            Category = new PolicyCategory();
        }
    }
}
