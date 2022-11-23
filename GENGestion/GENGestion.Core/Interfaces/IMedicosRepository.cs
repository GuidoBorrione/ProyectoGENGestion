using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IMedicosRepository : IGeneric<Medicos>
    {
        public string GetNombreMedicos(int id);

        Task<IEnumerable<Medicos>> GetMedicos();
    }
}
