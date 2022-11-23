using System;
using System.Collections.Generic;
using System.Text;
using GENGestion.Core.Interfaces;
using GENGestion.Core.Entities;

namespace GENGestion.Core.Interfaces
{
    public interface MedicosRepository : IGeneric<Medicos>
    {
        string GetNombreMedicoAsync(int id);
    }
}
