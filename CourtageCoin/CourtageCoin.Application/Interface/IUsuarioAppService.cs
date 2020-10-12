using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        string Login(Usuario usuario);
        Usuario GetUsuario(string login, string senha);
    }
}
