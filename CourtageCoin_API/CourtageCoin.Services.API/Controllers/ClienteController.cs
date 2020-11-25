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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;
        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(_clienteAppService.GetAll());
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
                return Ok(_clienteAppService.GetById(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Cliente cliente)
        {
            try
            {
                if(cliente == null)
                {
                    return NoContent();
                }

                _clienteAppService.Add(cliente);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Cliente cliente)
        {
            try
            {
                if(cliente == null)
                {
                    return NoContent();
                }
                if (ModelState.IsValid)
                {
                    _clienteAppService.Update(cliente);
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
