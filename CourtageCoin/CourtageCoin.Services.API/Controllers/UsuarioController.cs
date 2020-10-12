using CourtageCoin.Application.DTO.EntitiesDTO;
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
        public async Task<IActionResult> Login([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return NoContent();
            }

            var login = usuario.USU_STR_LOGIN;
            var senha = usuario.USU_STR_SENHA;
            var acesso = _usuarioAppService.GetUsuario(login, senha);


            if(acesso != null)
            {
                var token = _usuarioAppService.Login(acesso);
                var returnRequest = new
                {
                    login = acesso.USU_STR_LOGIN,
                    permissao = acesso.Perfil.PER_STR_NOME,
                    token
                };

                return Ok(returnRequest);
            }

            else
            {
                return Unauthorized();
            }
            
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_usuarioAppService.GetAll());
        }

        [Authorize(Roles = "Administrador")]
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

        [Authorize(Roles = "Administrador")]
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

        [Authorize(Roles = "Administrador")]
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
