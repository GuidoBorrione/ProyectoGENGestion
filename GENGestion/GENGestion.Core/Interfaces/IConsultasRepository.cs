using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IConsultasRepository
    {
        public string GetNombreConsulta();

        Task<IEnumerable<Consultas>> GetConsultas();
    }
}
