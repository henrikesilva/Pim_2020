using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class CarteiraService : ServiceBase<Carteira>, ICarteiraService
    {
        private readonly ICarteiraRepository _icarteiraRepository;
        private readonly ICarteiraReadOnlyRepository _icarteiraReadOnlyRepository;
        public CarteiraService(ICarteiraRepository carteiraRepository, ICarteiraReadOnlyRepository carteiraReadOnlyRepository) : base(carteiraRepository, carteiraReadOnlyRepository)
        {
            _icarteiraRepository = carteiraRepository;
            _icarteiraReadOnlyRepository = carteiraReadOnlyRepository;
        }

        public Carteira ConsultarAtivo(string nome)
        {
            return _icarteiraReadOnlyRepository.ConsultarAtivo(nome);
        }
    }
}
