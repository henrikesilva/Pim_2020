using AutoMapper;
using CourtageCoin.Application.DTO.EntitiesDTO;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class CarteiraAppService : AppServiceBase<Carteira>, ICarteiraAppService
    {
        private readonly ICarteiraService _carteiraService;
        private readonly IMapper _mapper;

        public CarteiraAppService(ICarteiraService carteiraService, IMapper mapper) : base(carteiraService, mapper)
        {
            _carteiraService = carteiraService;
            _mapper = mapper;
        }
    }
}
