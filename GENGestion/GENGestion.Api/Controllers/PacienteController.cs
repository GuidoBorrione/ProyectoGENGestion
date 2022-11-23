using GENGestion.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;



namespace GENGestion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacientesController(IPacientesRepository pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPacientes()
        {
            var pacientes = await _pacientesRepository.GetAll();
            return Ok(pacientes);
        }
    }
}
