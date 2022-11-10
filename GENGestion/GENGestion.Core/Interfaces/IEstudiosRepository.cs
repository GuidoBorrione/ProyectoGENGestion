using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IEstudiosRepository
    {
        public string GetNombreEstudios();

        Task<IEnumerable<Estudios>> GetEstudios();
    }
}
