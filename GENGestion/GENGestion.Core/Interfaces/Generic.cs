using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IGeneric<T>
    {
        T GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
