using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Domain.Services
{
    public class PerfilService : ServiceBase<Perfil>, IPerfilService
    {
        private IPerfilRepository _perfilRepository;
        public PerfilService(IPerfilRepository perfilRepository) : base(perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
    }
}
