using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface ITiposDePacientesRepository
    {
        public string GetNombreTipoDePacientes();

        Task<IEnumerable<TiposDePacientes>> GetTipoDePacientes();
    }
}
