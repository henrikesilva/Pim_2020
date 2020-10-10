using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                return NoContent();
            }

            var login = usuarioDTO.USU_STR_LOGIN;
            var senha = usuarioDTO.USU_STR_SENHA;
            var usuario = _usuarioAppService.GetUsuario(login, senha);


            if(usuario != null)
            {
                var token = _usuarioAppService.Login(usuarioDTO);
                var returnRequest = new
                {
                    login = usuario.USU_STR_LOGIN,
                    token
                };

                return Ok(returnRequest);
            }

            else
            {
                return Unauthorized();
            }
            
        }

        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_usuarioAppService.GetAll());
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario == null)
                {
                    return NoContent();
                }

                _usuarioAppService.Add(usuario);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<string> ObterPorId(int id)
        {
            try
            {
                if(id == 0)
                {
                    return NoContent();
                }

                return Ok(_usuarioAppService.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult Atualzar([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return NoContent();
                }

                _usuarioAppService.Update(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
