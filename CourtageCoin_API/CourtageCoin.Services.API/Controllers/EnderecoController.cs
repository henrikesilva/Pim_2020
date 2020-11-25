using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Services.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoAppService _enderecoAppService;
        public EnderecoController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(_enderecoAppService.GetAll());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(_enderecoAppService.GetById(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Endereco endereco)
        {
            try
            {
                if(endereco == null)
                {
                    return NoContent();
                }

                _enderecoAppService.Add(endereco);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Endereco endereco)
        {
            try
            {
                if(endereco == null)
                {
                    return NoContent();
                }
                if (ModelState.IsValid)
                {
                    _enderecoAppService.Update(endereco);
                }

                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
