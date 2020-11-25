using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Services.Api.Controllers
{
    [Route ("[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioAppService _funcionarioAppService;
        public FuncionarioController(IFuncionarioAppService funcionarioAppService)
        {
            _funcionarioAppService = funcionarioAppService;
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] Funcionario funcionario)
        {
            try
            {
                if(funcionario == null)
                {
                    return NoContent();
                }

                _funcionarioAppService.Add(funcionario);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                return Ok(_funcionarioAppService.GetAll());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> ObterPorId(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NoContent();
                }

                return Ok(_funcionarioAppService.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Atualzar([FromBody] Funcionario funcionario)
        {
            try
            {
                if (funcionario == null)
                {
                    return NoContent();
                }

                _funcionarioAppService.Update(funcionario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
