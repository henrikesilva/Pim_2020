using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>, IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository _ipessoaJuridicaRepository;
        private readonly IPessoaJuridicaReadOnlyRepository _ipessoaJuridicaReadOnlyRepository;
        public PessoaJuridicaService(IPessoaJuridicaRepository pessoaJuridicaRepository, IPessoaJuridicaReadOnlyRepository pessoaJuridicaReadOnlyRepository)
               : base(pessoaJuridicaRepository, pessoaJuridicaReadOnlyRepository)
        {
            _ipessoaJuridicaRepository = pessoaJuridicaRepository;
            _ipessoaJuridicaReadOnlyRepository = pessoaJuridicaReadOnlyRepository;
        }
    }
}
