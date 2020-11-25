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
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilAppService _perfilAppService;
        public PerfilController(IPerfilAppService perfilAppService)
        {
            _perfilAppService = perfilAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(_perfilAppService.GetAll());
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
                return Ok(_perfilAppService.GetById(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Perfil perfil)
        {
            try
            {
                if(perfil == null)
                {
                    return NoContent();
                }
                
                _perfilAppService.Add(perfil);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Perfil perfil)
        {
            try
            {
                if (perfil == null)
                {
                    return NoContent();
                }
                
                if (ModelState.IsValid)
                {
                    _perfilAppService.Update(perfil);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
