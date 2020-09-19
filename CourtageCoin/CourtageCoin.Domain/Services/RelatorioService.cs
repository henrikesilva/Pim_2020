using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class RelatorioService : ServiceBase<Relatorio>, IRelatorioService
    {
        private readonly IRelatorioRepository _irelatorioRepository;
        private readonly IRelatorioReadOnlyRepository _irelatorioReadOnlyRepository;
        public RelatorioService(IRelatorioRepository relatorioRepository, IRelatorioReadOnlyRepository relatorioReadOnlyRepository)
            : base(relatorioRepository, relatorioReadOnlyRepository)
        {
            _irelatorioRepository = relatorioRepository;
            _irelatorioReadOnlyRepository = relatorioReadOnlyRepository;
        }
    }
}
