using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Usuario Login(string login, string senha);
    }
}
