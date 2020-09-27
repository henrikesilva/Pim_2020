using AutoMapper;
using CourtageCoin.Application.DTO.Models;
using CourtageCoin.Application.Interfaces;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class CarteiraAppService : ICarteiraAppService
    {
        private readonly ICarteiraService _carteiraService;
        private readonly IMapper _mapper;

        public CarteiraAppService(ICarteiraService carteiraService, IMapper mapper)
        {
            _carteiraService = carteiraService;
            _mapper = mapper;
        }

        #region [ESCRITA]
        public void Adicionar(CarteiraDTO carteira)
        {
            _carteiraService.Adicionar(_mapper.Map<Carteira>(carteira));
        }

        public void Atualizar(CarteiraDTO carteira)
        {
            _carteiraService.Atualizar(_mapper.Map<Carteira>(carteira));
        }

        public void Remover(CarteiraDTO carteira)
        {
            _carteiraService.Remover(_mapper.Map<Carteira>(carteira));
        }
        #endregion

        #region [CONSULTA]

        public CarteiraDTO ObterPorId(int Id)
        {
            return _mapper.Map<CarteiraDTO>(_carteiraService.GetByID(Id));
        }

        public IEnumerable<CarteiraDTO> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CarteiraDTO>>(_carteiraService.GetAll());
        }
        #endregion


        public void Dispose()
        {
            _carteiraService.Dispose();
        }
    }
}
