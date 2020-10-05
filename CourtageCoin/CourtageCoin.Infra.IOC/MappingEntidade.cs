using AutoMapper;
using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}
