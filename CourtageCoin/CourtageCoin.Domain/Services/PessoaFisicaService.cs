using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _ipessoaFisicaRepository;
        private readonly IPessoaFisicaReadOnlyRepository _ipessoaFisicaReadOnlyRepository;
        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository, IPessoaFisicaReadOnlyRepository pessoaFisicaReadOnlyRepository) 
            : base(pessoaFisicaRepository, pessoaFisicaReadOnlyRepository)
        {
            _ipessoaFisicaRepository = pessoaFisicaRepository;
            _ipessoaFisicaReadOnlyRepository = pessoaFisicaReadOnlyRepository;
        }
    }
}
