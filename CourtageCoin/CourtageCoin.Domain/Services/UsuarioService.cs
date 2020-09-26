using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>
    {
        private readonly IUsuarioWriteRepository _usuarioWriteRepository;
        private readonly IUsuarioReadOnlyRepository _usuarioReadOnlyRepository;

        public UsuarioService(IUsuarioWriteRepository usuarioWriteRepository, IUsuarioReadOnlyRepository usuarioReadOnlyRepository) 
            : base (usuarioWriteRepository, usuarioReadOnlyRepository)
        {
            _usuarioWriteRepository = usuarioWriteRepository;
            _usuarioReadOnlyRepository = usuarioReadOnlyRepository;
        }
    }
}
