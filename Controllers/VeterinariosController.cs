using ClinicaVetApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaVetApi.Models;

namespace ClinicaVetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async
            Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();

        }


        [HttpPost]
        public async
            Task<ActionResult> CadastrarVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Veterinario Cadastrado com sucesso!!!");

        }
    }
}
