using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Domain.Services
{
    public class CarteiraService : ServiceBase<Carteira>, ICarteiraService
    {
        private ICarteiraRepository _carteiraRepository;
        public CarteiraService(ICarteiraRepository carteiraRepository) : base(carteiraRepository)
        {
            _carteiraRepository = carteiraRepository;
        }
    }
}
