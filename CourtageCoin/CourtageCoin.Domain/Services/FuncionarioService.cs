using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>
    {
        private readonly IFuncionarioWriteRepository _funcionarioWriteRepository;
        private readonly IFuncionarioReadOnlyRepository _funcionarioReadOnlyRepository;

        public FuncionarioService(IFuncionarioWriteRepository funcionarioWriteRepository, IFuncionarioReadOnlyRepository funcionarioReadOnlyRepository) 
            : base(funcionarioWriteRepository, funcionarioReadOnlyRepository)
        {
            _funcionarioWriteRepository = funcionarioWriteRepository;
            _funcionarioReadOnlyRepository = funcionarioReadOnlyRepository;
        }
    }
}
