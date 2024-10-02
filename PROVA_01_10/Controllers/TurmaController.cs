using Microsoft.AspNetCore.Mvc;
using PROVA_01_10.Services;
using PROVA_01_10.Models;
namespace PROVA_01_10.Controllers
{
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaController(ITurmaRepository turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        [HttpPost]
        [Route("Adicionar")]
        
        public IActionResult Adicionar(Turma pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _turmaRepository.Adicionar(pessoa);

            return Ok($"{pessoa.Nome} Adicionada com sucesso.");
        }

        [HttpGet]
        [Route("Mostrar Lista")]
        public IActionResult MostrarLista()
        {
            var lista = _turmaRepository.MostrarLista();
            return Ok(lista);
        }


    }
}
