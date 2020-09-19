using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly.Common;

namespace CourtageCoin.Domain.Interfaces.Services.ReadOnly
{
    public interface IPessoaJuridicaReadOnlyRepository : IServiceBase<PessoaJuridica>, IBaseReadOnlyRepository<PessoaJuridica>
    {
    }
}
