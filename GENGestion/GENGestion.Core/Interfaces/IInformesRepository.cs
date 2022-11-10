using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IInformesRepository
    {
        public string GetNombreInformes();

        Task<IEnumerable<Informes>> GetInformes();
    }
}
