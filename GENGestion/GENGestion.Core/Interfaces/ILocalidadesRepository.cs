using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface ILocalidadesRepository
    {
        public string GetNombreLocalidades();

        Task<IEnumerable<Localidades>> GetLocalidades();
    }
}
