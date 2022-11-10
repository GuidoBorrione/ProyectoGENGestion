using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GENGestion.Core.Interfaces
{
    public interface IMedicacionesRepository
    {
        public string GetNombreMedicaciones();

        Task<IEnumerable<Medicaciones>> GetMedicaciones();
    }
}
