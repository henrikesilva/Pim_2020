using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        string Login(UsuarioDTO usuarioDTO);
        UsuarioDTO GetUsuario(string login, string senha);
    }
}
