using GENGestion.Core.Entities;
using GENGestion.Core.Interfaces;
using GENGestion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Infrastructure.Repositories
{
    public class ConsultasRepository : IConsultasRepository

    {
        private readonly GENGestionContext _context;

        public ConsultasRepository(GENGestionContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Consultas>> GetConsultas()
        {

            var consultas = await _context.Consultas.ToListAsync();
            return (IEnumerable<Consultas>)consultas;
        }

        public string GetNombreConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
