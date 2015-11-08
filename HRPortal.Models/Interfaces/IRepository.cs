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

        List<State> GetAllStates();
        List<Position> GetAllPositions();

        List<PolicyCategory> GetPolicyCategories();
        List<Policy> GetAllPolicies();

        List<Policy> GetPoliciesListInCategory(PolicyCategory category);
        Policy GetPolicyById(int id);

        void RemovePolicyById(int id);

        void AddNewPolicyInExistingCategory(Policy newPolicy);
        void AddNewPolicyInNewCategory(Policy newPolicy);
    }
}
