using ClinicaVetApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaVetApi.Models;

namespace ClinicaVetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TutoresController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async
            Task<ActionResult<IEnumerable<Tutor>>> GetTutores()
        {
            return await _context.Tutores.ToListAsync();

        }


        [HttpPost]
        public async
            Task<ActionResult> CadastrarTutor(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok("Pet Cadastrado com sucesso!!!");

        }
    }
}

   
