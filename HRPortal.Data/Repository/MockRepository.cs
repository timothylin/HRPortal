using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class MockRepository : IRepository
    {
        public List<Application> AppsList { get; set; }

        public MockRepository()
        {
            AppsList = new List<Application>();
        } 

        public List<Application> GetAll()
        {
            return AppsList;
        }

        public Application GetById(int id)
        {
            return AppsList.FirstOrDefault(a => a.AppId == id);
        }

        public void Add(Application newApp)
        {
            AppsList.Add(newApp);
        }
    }
}
