using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services.Common;

namespace CourtageCoin.Domain.Interfaces.Services
{
    public interface ICarteiraService : IServiceBase<Carteira>, IReadOnlyServiceBase<Carteira>
    {
        Carteira ConsultarAtivo(string nome);
    }
}
