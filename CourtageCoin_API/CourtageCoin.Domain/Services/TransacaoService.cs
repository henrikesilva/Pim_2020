using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Domain.Services
{
    public class TransacaoService : ServiceBase<Transacao>, ITransacaoService
    {
        private ITransacaoRepository _transacaoRepository;
        public TransacaoService(ITransacaoRepository transacaoRepository) : base(transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }
    }
}
