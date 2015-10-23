using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Response _response;

        public RepoOperations()
        {
            _repo = Factory.CreateRepository();
            _response = new Response();
        }

        //View All Apps
        public Response ViewAllApps()
        {
            var appsList = _repo.GetAll();

            if (appsList.Count != 0)
            {
                _response.Success = true;
                _response.Message = "You have succesfully pulled the list of apps.";
                _response.ApplicationsList = appsList;
            }
            else
            {
                _response.Success = false;
                _response.Message = "There are no applications to view.";
            }

            return _response;
        }


        //Add new application
        public Response AddAppToRepo(Application newApp)
        {
            _repo.Add(newApp);

            var appInfo = _repo.GetById(newApp.AppId);


            if (appInfo != null)
            {
                _response.Success = true;
                _response.Message = "You have successfully submitted your application.";
                _response.Application = newApp;
            }
            else
            {
                _response.Success = false;
                _response.Message = "Your application was not submitted.";
            }
            return _response;

            
        }

    }
}
