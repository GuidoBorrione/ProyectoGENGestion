using GENGestion.Core.Entities;
using GENGestion.Core.Interfaces;
using GENGestion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Esto hay que solucionar
namespace GENGestion.Infrastructure.Repositories
{
    public class PacientesRepository : IGeneric<Pacientes>
    {
        private readonly GENGestionContext _context;
        public PacientesRepository(GENGestionContext context)
        {
            _context = context;
        }
        public string GetNombrePacientes()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetNombrePacientesAsync(int id)
        {
            var m = await _context.Pacientes.Select(selector: x => x.Id == id);
            return "Hola";
        }

        public Pacientes GetById(int id)
        {
            throw new NotImplementedException();
        }

        string IPacientesRepository.GetNombrePacientesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Pacientes>> GetAll()
        {
            var pacientes = await _context.Pacientes.TolistAsync();
            return pacientes;
        }
    }


}

