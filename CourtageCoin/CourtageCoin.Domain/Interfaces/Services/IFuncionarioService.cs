using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;

namespace CourtageCoin.Domain.Interfaces.Services
{
    public interface IFuncionarioService : IServiceBase<Funcionario>, IReadOnlyServiceBase<Funcionario>
    {
    }
}
