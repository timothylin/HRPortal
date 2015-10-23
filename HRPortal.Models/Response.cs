using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public Application Application { get; set; }
        public List<Application> ApplicationsList { get; set; } 

        public Response()
        {
            Application = new Application();
            ApplicationsList = new List<Application>();
        }
    }
}
