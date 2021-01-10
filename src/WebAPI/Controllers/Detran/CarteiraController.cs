using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class CarteiraController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranConsultarCarteiraService _DetranConsultaCarteiraServices;

        public CarteiraController(IMapper mapper, IDetranConsultarCarteiraService detranConsultaCarteiraServices)
        {
            _Mapper = mapper;
            _DetranConsultaCarteiraServices = detranConsultaCarteiraServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<Carteira>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery] string numero)
        {
            var carteira = await _DetranConsultaCarteiraServices.ConsultarCarteira(numero);

            var result = new SuccessResultModel<Carteira>(_Mapper.Map<Carteira>(carteira));

            return Ok(result);

        }
    }
}
