﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class ProdRepository : IRepository
    {

        //var rootPath = Server.MapPath("~/");

        
        public void AddResume(Resume newApp)
        {
            throw new NotImplementedException();
        }

        public List<Resume> GetAllResumes()
        {
            throw new NotImplementedException();
        }

        public Resume GetResumeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetAllPositions()
        {
            throw new NotImplementedException();
        }

        public List<State> GetAllStates()
        {
            throw new NotImplementedException();
        }

        public List<PolicyCategory> GetPolicyCategories()
        {
            throw new NotImplementedException();
        }

        public List<Policy> GetPoliciesList()
        {
            throw new NotImplementedException();
        }
    }
}
