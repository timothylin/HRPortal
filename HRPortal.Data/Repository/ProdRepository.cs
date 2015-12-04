using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using HRPortal.Models;
using HRPortal.Models.Interfaces;

namespace HRPortal.Data.Repository
{
    public class ProdRepository : IRepository
    {

        //var rootPath = Server.MapPath("~/");
        //http://csharp.net-tutorials.com/xml/introduction/
        //http://forums.asp.net/t/1416938.aspx?How+to+create+add+multiple+nodes+in+xml+file+please+help
        //http://stackoverflow.com/questions/11492705/how-to-create-xml-document-using-xmldocument
        //http://www.dotnetcurry.com/linq/564/linq-to-xml-tutorials-examples

        public void AddResume(Resume newApp)
        {
            throw new NotImplementedException();
        }

        public List<Resume> GetAllResumes()
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

        public List<Policy> GetAllPolicies()
        {
            throw new NotImplementedException();
        }

        public List<Policy> GetPoliciesListInCategory(PolicyCategory category)
        {
            throw new NotImplementedException();
        }

        public Policy GetPolicyById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePolicyById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddNewPolicyInExistingCategory(Policy newPolicy)
        {
            throw new NotImplementedException();
        }

        public void AddNewPolicyInNewCategory(Policy newPolicy)
        {
            throw new NotImplementedException();
        }

        public Policy AddNewPolicy(Policy newPolicy)
        {
            throw new NotImplementedException();
        }

        public Resume GetResumeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
