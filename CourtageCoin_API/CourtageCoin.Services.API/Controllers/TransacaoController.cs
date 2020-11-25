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
    public class TransacaoController : ControllerBase
    {
        private readonly ITransacaoAppService _transacaoAppService;
        public TransacaoController(ITransacaoAppService transacaoAppService)
        {
            _transacaoAppService = transacaoAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(_transacaoAppService.GetAll());
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
                return Ok(_transacaoAppService.GetById(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Insert(Transacao transacao)
        {
            try
            {
                if(transacao == null)
                {
                    return NoContent();
                }

                _transacaoAppService.Add(transacao);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpPut("{id}")]
        public ActionResult Update(Transacao transacao)
        {
            try
            {
                if(transacao == null)
                {
                    return NoContent();
                }

                if (ModelState.IsValid)
                {
                    _transacaoAppService.Update(transacao);
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
