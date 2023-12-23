using AutenticacaoMultifator.Application.Services.Colaborador;
using AutenticacaoMultifator.Domain.Entidades;
using AutenticacaoMultifator.Domain.Validation;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoMultifator.API.Controllers.V1
{
    [ApiController]
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorController(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet("listar")]
        public ActionResult<IEnumerable<Colaborador>> Listar()
        {
            try
            {
                return Ok(_colaboradorService.ListarColaboradores());
            }
            catch (ExceptionValidacao ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}