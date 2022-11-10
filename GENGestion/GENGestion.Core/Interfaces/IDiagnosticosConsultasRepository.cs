using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IDiagnosticosConsultasRepository
    {
        public string GetNombreDiagnosticosConsultas();

        Task<IEnumerable<DiagnosticosConsultas>> GetDiagnosticosConsultas();
    }
}
