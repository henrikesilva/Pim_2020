using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>
    {
        private readonly IPessoaFisicaWriteRepository _pessoaFisicaWriteRepository;
        private readonly IPessoaFisicaReadOnlyRepository _pessoaFisicaReadOnlyRepository;
        public PessoaFisicaService(IPessoaFisicaWriteRepository pessoaFisicaWriteRepository, IPessoaFisicaReadOnlyRepository pessoaFisicaReadOnlyRepository) 
            : base(pessoaFisicaWriteRepository, pessoaFisicaReadOnlyRepository)
        {
            _pessoaFisicaWriteRepository = pessoaFisicaWriteRepository;
            _pessoaFisicaReadOnlyRepository = pessoaFisicaReadOnlyRepository;
        }
    }
}
