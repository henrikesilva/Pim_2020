using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class CarteiraService : ServiceBase<Carteira>
    {
        private readonly ICarteiraWriteRepository _carteiraWriteRepository;
        private readonly ICarteiraReadOnlyRepository _carteiraReadOnlyRepository;

        public CarteiraService(ICarteiraWriteRepository carteiraWriteRepository, ICarteiraReadOnlyRepository carteiraReadOnlyRepository)
            : base(carteiraWriteRepository, carteiraReadOnlyRepository)
        {
            _carteiraWriteRepository = carteiraWriteRepository;
            _carteiraReadOnlyRepository = carteiraReadOnlyRepository;
        }
    }
}
