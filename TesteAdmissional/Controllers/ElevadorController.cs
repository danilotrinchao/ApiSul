using Microsoft.AspNetCore.Mvc;
using TesteAdmissional.Interface;

namespace TesteAdmissional.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[ApiController]

    public class ElevadorController : Controller
    {
        private readonly IElevadorService _elevadorService;

        public ElevadorController(IElevadorService elevadorService)
        {
            _elevadorService = elevadorService;
          
        }
        
        [HttpGet("ConsultarAndarMenosUtilizado")]
        public IActionResult ConsultarAndarMenosUtilizado()
        {
            var AndarMenosUtilizado = _elevadorService.andarMenosUtilizado();
            return Ok(AndarMenosUtilizado);
        }
        [HttpGet("ConsultarElevadorMaisFrequentado")]
        public IActionResult ConsultarElevadorMaisFrequentado()
        {
            var ElevadorMaisFrequentado = _elevadorService.elevadorMaisFrequentado();
            return Ok(ElevadorMaisFrequentado);
        }
        [HttpGet("ConsultarPeriodoMaiorFluxoElevadorMaisFrequentado")]
        public IActionResult ConsultarPeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            var PeriodoMaiorFluxoElevadorMaisFrequentado = _elevadorService.periodoMaiorFluxoElevadorMaisFrequentado();
            return Ok(PeriodoMaiorFluxoElevadorMaisFrequentado);
        }
        [HttpGet("ConsultarElevadorMenosFrequentado")]
        public IActionResult ConsultarElevadorMenosFrequentado()
        {
            var ElevadorMenosFrequentado = _elevadorService.elevadorMenosFrequentado();
            return Ok(ElevadorMenosFrequentado);
        }
        [HttpGet("ConsultarPeriodoMenorFluxoElevadorMenosFrequentado")]
        public IActionResult ConsultarPeriodoMenorFluxoElevadorMenosFrequentado()
        {
            var periodoMenorFluxoElevadorMenosFrequentado = _elevadorService.periodoMenorFluxoElevadorMenosFrequentado();
            return Ok(periodoMenorFluxoElevadorMenosFrequentado);
        }
        [HttpGet("ConsultarPeriodoMaiorUtilizacaoConjuntoElevadores")]
        public IActionResult ConsultarPeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            var PeriodoMaiorUtilizacaoConjuntoElevadores = _elevadorService.periodoMaiorUtilizacaoConjuntoElevadores();
            return Ok(PeriodoMaiorUtilizacaoConjuntoElevadores);
        }
        [HttpGet("ConsultaPercentualDeUsoElevadorA")]
        public IActionResult ConsultaPercentualDeUsoElevadorA()
        {
            var PercentualDeUsoElevadorA = _elevadorService.percentualDeUsoElevadorA();
            return Ok(PercentualDeUsoElevadorA);
        }
        [HttpGet("ConsultaPercentualDeUsoElevadorB")]
        public IActionResult ConsultaPercentualDeUsoElevadorB()
        {
            var PercentualDeUsoElevadorB = _elevadorService.percentualDeUsoElevadorB();
            return Ok(PercentualDeUsoElevadorB);
        }
        [HttpGet("ConsultaPercentualDeUsoElevadorC")]
        public IActionResult ConsultaPercentualDeUsoElevadorC()
        {
            var PercentualDeUsoElevadorC = _elevadorService.percentualDeUsoElevadorC();
            return Ok(PercentualDeUsoElevadorC);
        }
        [HttpGet("ConsultaPercentualDeUsoElevadorD")]
        public IActionResult ConsultaPercentualDeUsoElevadorD()
        {
            var PercentualDeUsoElevadorD = _elevadorService.percentualDeUsoElevadorD();
            return Ok(PercentualDeUsoElevadorD);
        }
        [HttpGet("ConsultaPercentualDeUsoElevadorE")]
        public IActionResult ConsultaPercentualDeUsoElevadorE()
        {
            var PercentualDeUsoElevadorE = _elevadorService.percentualDeUsoElevadorE();
            return Ok(PercentualDeUsoElevadorE);
        }


    }
}
