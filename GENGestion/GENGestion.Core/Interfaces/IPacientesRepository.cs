using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IPacientesRepository : IGeneric<Pacientes>
    {
        public string GetNombrePacientes();

        Task<IEnumerable<Pacientes>> GetPacientes();
        string GetNombrePacientesAsync(int id);
    }
}
