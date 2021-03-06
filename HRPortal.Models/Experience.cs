﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Experience
    {
        public string Company { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public Address Location { get; set; }
        public string Description { get; set; }
        public string SupervisorName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string SupervisorPhone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string SupervisorEmail { get; set; }

        public Experience()
        {
            Location = new Address();
        }
    }
}
