using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario Login(string login, string senha);
    }
}
