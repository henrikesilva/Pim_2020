using AutoMapper;
using CourtageCoin.Application.DTO.EntitiesDTO;
using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Infra.CrossCutting.IOC
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Carteira, CarteiraDTO>();
            CreateMap<CarteiraDTO, Carteira>();

            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Endereco, EnderecoDTO>();
            CreateMap<EnderecoDTO, Endereco>();

            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<FuncionarioDTO, Funcionario>();

            CreateMap<Perfil, PerfilDTO>();
            CreateMap<PerfilDTO, Perfil>();
            
            CreateMap<Transacao, TransacaoDTO>();
            CreateMap<TransacaoDTO, Transacao>();

            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}
