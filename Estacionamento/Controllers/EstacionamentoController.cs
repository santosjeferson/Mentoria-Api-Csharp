using Estacionamento.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    [ApiController]
    [Route("api/v1/estacionamento")]
    public class EstacionamentoController : ControllerBase
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public EstacionamentoController(IEstacionamentoRepository estacionamentoRepository)
        {
            _estacionamentoRepository = estacionamentoRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllEstacionamento()
        {
            var estacionamentos = await _estacionamentoRepository.GetEstacionamento();

            if (estacionamentos.Any())
                return Ok(estacionamentos);

            return NotFound();
        }

        //[HttpPost]
        //public async Task<IActionResult> PostEstacionamento()
        //{
        //    var estacionamentos = await _estacionamentoRepository.InsertEstacionamento();

        //    if (estacionamentos)
        //        return Ok("Salvo com sucesso!");

        //    return BadRequest();
        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateEstacionamento()
        //{
        //    var estacionamentos = await _estacionamentoRepository.UpdateEstacionamento();

        //    if (estacionamentos)
        //        return Ok("Atualizado com sucesso!");

        //    return BadRequest();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> UpdateEstacionamento(int id)
        //{
        //    var estacionamentos = await _estacionamentoRepository.DeleteEstacionamento(id);

        //    if (estacionamentos)
        //        return Ok("Removido com sucesso!");

        //    return BadRequest();
        //}
    }
}