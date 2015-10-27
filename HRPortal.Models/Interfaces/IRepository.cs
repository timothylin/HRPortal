using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models.Interfaces
{
    public interface IRepository
    {
        List<Resume> GetAll();
        void Add(Resume newApp);
        Resume GetById(int id);

        List<State> GetListOfStates();
        List<Position> GetListOfPositions();
    }
}
