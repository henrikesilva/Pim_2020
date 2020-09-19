using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;

namespace CourtageCoin.Domain.Interfaces.Services
{
    interface IPessoaJuridicaService : IServiceBase<PessoaJuridica>, IReadOnlyServiceBase<PessoaJuridica>
    {
    }
}
