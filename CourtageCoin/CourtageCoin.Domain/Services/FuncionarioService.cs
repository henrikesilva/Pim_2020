using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _ifuncionarioRepository;
        private readonly IFuncionarioReadOnlyRepository _ifuncionarioReadOnlyRepository;
        public FuncionarioService(IFuncionarioRepository funcionarioRepository, IFuncionarioReadOnlyRepository funcionarioReadOnlyRepository) 
            : base (funcionarioRepository, funcionarioReadOnlyRepository)
        {
            _ifuncionarioRepository = funcionarioRepository;
            _ifuncionarioReadOnlyRepository = funcionarioReadOnlyRepository;
        }
    }
}
