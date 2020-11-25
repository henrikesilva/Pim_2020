using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Application.Services
{
    public class TransacaoAppService : AppServiceBase<Transacao>, ITransacaoAppService
    {
        private readonly ITransacaoService _transacaoService;
        private readonly IMapper _mapper;

        public TransacaoAppService(ITransacaoService transacaoService, IMapper mapper) : base(transacaoService, mapper)
        {
            _transacaoService = transacaoService;
            _mapper = mapper;
        }
    }
}
