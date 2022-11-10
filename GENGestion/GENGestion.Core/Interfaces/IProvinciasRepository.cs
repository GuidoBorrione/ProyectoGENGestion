using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IProvinciasRepository
    {
        public string GetNombreProvincias();

        Task<IEnumerable<Provincias>> GetProvincias();
    }
}
