﻿using System;
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

        //Find out list of current Policy categories
        public List<PolicyCategory> ReturnListOfPolicyCategories()
        {
            return _repo.GetPolicyCategories();
        }

        //List of All Policies
        public List<Policy> ReturnAllPolicies()
        {
            return _repo.GetAllPolicies();
        }

        //List of Policies in a certain Policy category
        public List<Policy> ReturnListOfPoliciesInCategory(PolicyCategory category)
        {
            return _repo.GetPoliciesListInCategory(category);
        }

        //Return a Policy by Id
        public Policy ReturnPolicyById(int id)
        {
            return _repo.GetPolicyById(id);
        }

        //Determine highest PolicyId number
        public int HighestPolicyIdNum()
        {
            var allPolicies = _repo.GetAllPolicies();
            var maxPolicyId = allPolicies.OrderByDescending(p => p.PolicyId).Select(p => p.PolicyId).FirstOrDefault();
            return maxPolicyId;
        }

        //Remove a policy by Id
        public void RemovePolicyByIdOp(int id)
        {
            _repo.RemovePolicyById(id);
        }

        //Add a new policy into an existing category
        public void AddNewPolicyInExistingCat(Policy newPolicy)
        {
            _repo.AddNewPolicyInExistingCategory(newPolicy);
        }

        //Add a new policy into a new category
        public void AddNewPolicyInNewCat(Policy newPolicy)
        {
            _repo.AddNewPolicyInNewCategory(newPolicy);
        }

        //Add new policy (sql)
        public Policy AddNewPolicy(Policy newPolicy)
        {
            return _repo.AddNewPolicy(newPolicy);
        }
    }
}
