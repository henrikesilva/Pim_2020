using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class PessoaJuridicaService : ServiceBase<PessoaJuridica>
    {
        private readonly IPessoaJuridicaWriteRepository _pessoaJuridicaWriteRepository;
        private readonly IPessoaJuridicaReadOnlyRepository _pessoaJuridicaReadOnlyRepository;
        public PessoaJuridicaService(IPessoaJuridicaWriteRepository pessoaJuridicaWriteRepository, IPessoaJuridicaReadOnlyRepository pessoaJuridicaReadOnlyRepository) 
            : base(pessoaJuridicaWriteRepository, pessoaJuridicaReadOnlyRepository)
        {
            _pessoaJuridicaWriteRepository = pessoaJuridicaWriteRepository;
            _pessoaJuridicaReadOnlyRepository = pessoaJuridicaReadOnlyRepository;
        }
    }
}
