using CourtageCoin.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CourtageCoin.Services.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_usuarioAppService.GetAll());
        }
    }
}
