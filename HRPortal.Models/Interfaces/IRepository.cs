using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models.Interfaces
{
    public interface IRepository
    {
        List<Application> GetAll();
        void Add(Application newApp);
        Application GetById(int id);

        List<State> GetListOfStates();
        List<Position> GetListOfPositions();
    }
}
