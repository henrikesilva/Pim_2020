using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Services.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CarteiraController : ControllerBase
    {
        private readonly ICarteiraAppService _carteiraAppService;
        public CarteiraController(ICarteiraAppService carteiraAppService)
        {
            _carteiraAppService = carteiraAppService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(_carteiraAppService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(_carteiraAppService.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Insert([FromBody] Carteira carteira)
        {
            try
            {
                if(carteira == null)
                {
                    return NoContent();
                }

                _carteiraAppService.Add(carteira);
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Carteira carteira)
        {
            try
            {
                if(carteira == null)
                {
                    return NoContent();
                }
                if (ModelState.IsValid)
                {
                    _carteiraAppService.Update(carteira);
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
