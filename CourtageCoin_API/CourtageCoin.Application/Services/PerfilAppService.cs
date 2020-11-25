using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Application.Services
{
    public class PerfilAppService : AppServiceBase<Perfil>, IPerfilAppService
    {
        private readonly IPerfilService _perfilService;
        private readonly IMapper _mapper;

        public PerfilAppService(IPerfilService perfilService, IMapper mapper) : base(perfilService, mapper)
        {
            _perfilService = perfilService;
            _mapper = mapper;
        }
    }
}
