using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IDiagnosticosRepository
    {
        public string GetNombreDiagnosticos();

        Task<IEnumerable<Diagnosticos>> GetDiagnosticos();
    }
}
