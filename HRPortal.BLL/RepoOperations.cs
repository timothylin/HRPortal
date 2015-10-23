using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Data.Repository;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.BLL
{
    public class RepoOperations
    {
        private IRepository _repo;

        public RepoOperations()
        {
            _repo = Factory.CreateRepository();
        }

        //View All Apps
        public void ViewAllApps()
        {
            
        }


        //Add new application
        public Response AddAppToRepo(Application newApp)
        {
            _repo.

            var response = new Response();
            return response;
        }

    }
}
