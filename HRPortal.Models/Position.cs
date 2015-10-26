using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ClosingDate { get; set; }
    }
}
