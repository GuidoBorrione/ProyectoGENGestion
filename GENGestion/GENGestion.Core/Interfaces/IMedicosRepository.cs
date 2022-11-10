using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IMedicosRepository
    {
        public string GetNombreMedicos();

        Task<IEnumerable<Medicos>> GetMedicos();
    }
}
