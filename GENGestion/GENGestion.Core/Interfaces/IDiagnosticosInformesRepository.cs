using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IDiagnosticosInformesRepository
    {
        public string GetNombreDiagnosticoInformes();

        Task<IEnumerable<DiagnosticosInformes>> GetDiagnosticosInformes();
    }
}
