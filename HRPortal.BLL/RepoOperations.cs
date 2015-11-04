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
        private static IRepository _repo = Factory.CreateRepository();
        private Response _response;

        public RepoOperations()
        {
            //_repo = Factory.CreateRepository();
            _response = new Response();
        }

        //View All Apps
        public Response ViewAllApps()
        {
            var appsList = _repo.GetAllResumes();

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

        // View particular app
        public Response GetAppById(int id)
        {
            var app = _repo.GetResumeById(id);

            if (app != null)
            {
                _response.Success = true;
                _response.Message = "Here is your application.";
                _response.Application = app;
            }
            else
            {
                _response.Success = false;
                _response.Message = "Your application was not found.";
            }

            return _response;
        }


        //Add new application
        public Response AddAppToRepo(Resume newApp)
        {
            _repo.AddResume(newApp);

            var appInfo = _repo.GetResumeById(newApp.AppId);


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


        //Determine highest AppID number (problem with null if no applications in the list **Added work around LINQ but long)
        public int HighestAppIDNum()
        {
            var allApps = _repo.GetAllResumes();
            //var maxAppID = allApps.Max(a => a.AppId);
            var maxAppID = allApps.OrderByDescending(a => a.AppId).Select(a => a.AppId).FirstOrDefault();
            return maxAppID;
        }


        //Find out list of States
        public List<State> ReturnListOfStates()
        {
            return _repo.GetAllStates();
        } 

        //Find out List of Positions available
        public List<Position> ReturnListOfPositions()
        {
            return _repo.GetAllPositions();
        } 

    }
}
