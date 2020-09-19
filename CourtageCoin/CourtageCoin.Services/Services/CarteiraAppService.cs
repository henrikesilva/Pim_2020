using AutoMapper;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Services.DTO.Models;
using CourtageCoin.Services.Interfaces;

namespace CourtageCoin.Services.Services
{
    public class CarteiraAppService : ICarteiraAppServices
    {
        private readonly ICarteiraService _carteiraService;
        private readonly IMapper _mapper;

        public CarteiraAppService(ICarteiraService carteiraService, IMapper mapper)
        {
            _carteiraService = carteiraService;
            _mapper = mapper;
        }

        public CarteiraDTO ConsultarAtivo(string nome)
        {
            return _mapper.Map<CarteiraDTO>(_carteiraService.ConsultarAtivo(nome));
        }

        public void IncluirAtivo(CarteiraDTO ativo)
        {
            _carteiraService.Adicionar(_mapper.Map<Carteira>(ativo));
        }

        public void VenderAtivo(int codigoAtivo)
        {
            _carteiraService.Remover(_mapper.Map<Carteira>(codigoAtivo));
        }
    }
}
