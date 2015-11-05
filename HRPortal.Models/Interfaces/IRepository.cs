using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models.Interfaces
{
    public interface IRepository
    {
        List<Resume> GetAllResumes();
        void AddResume(Resume newApp);
        Resume GetResumeById(int id);

        List<State> GetAllStates();
        List<Position> GetAllPositions();

        List<PolicyCategory> GetPolicyCategories();
        //List<Policy> GetPoliciesList();
        List<Policy> GetAllPolicies();

        List<Policy> GetPoliciesListInCategory(PolicyCategory category);
        Policy GetPolicyById(int id);
    }
}
