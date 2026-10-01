using CascaApi.Models;
using CascaApi.Repository;
using Microsoft.AspNetCore.Mvc;
namespace CascaApi.Controllers

{
    [ApiController]
    [Route("Eleitor")]
    public class EleitorController : ControllerBase
    {
        
        private readonly IEleitorRepository _eleitorRepository;
        private readonly ListaTurno _listaTurno;

        public EleitorController(IEleitorRepository eleitorRepository, ListaTurno listaTurno)
        {
            _eleitorRepository = eleitorRepository;
            _listaTurno = listaTurno;
        }

        [HttpPost]
        public IActionResult CadastrarEleitor([FromQuery] string nome, [FromQuery] string CPF, [FromQuery] string titulo, [FromQuery] string UF)
        {
            try
            {
                Eleitor eleitor = new Eleitor(nome, UF, CPF, titulo);
                _eleitorRepository.IncluirEleitor(eleitor);
                return Created("/Eleitor", eleitor);
            }
            catch (InvalidOperationException exception)
            {
                return Conflict(exception.Message);
            }
        }

        [HttpGet]
        public IActionResult ListarEleitores()
        {
            return Ok(_eleitorRepository.ListarEleitores());
        }

        [HttpPost]
        [Route("RegistrarAusencia")]
        public IActionResult RegistrarAusencia(string CPF, int turno, string desc)
        {
            if (_eleitorRepository.ConsultarEleitor(CPF))
            {
                _listaTurno.RegistrarJustificativa(CPF, turno, desc);
                return Ok();
            } else 
            {
                return BadRequest("Eleitor não encontrado!");
            }
        }

        [HttpGet]
        [Route("ListarJustificativas")]
        public IActionResult ListarJustificativas()
        {
            string output = _listaTurno.ListarJustificativas();
            return Ok(output);
        }
    }
}
