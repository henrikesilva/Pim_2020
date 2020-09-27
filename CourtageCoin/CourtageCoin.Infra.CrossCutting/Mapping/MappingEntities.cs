using AutoMapper;
using CourtageCoin.Application.DTO.Models;
using CourtageCoin.Domain.Entities;

namespace CourtageCoin.Infra.CrossCutting.Mapping
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            //ADICIONAR OS MAPEAMENTO COM AS ENTIDADES DTO
            CreateMap<Carteira, CarteiraDTO>();
            CreateMap<CarteiraDTO, Carteira>();

            CreateMap<Cidade, CidadeDTO>();
            CreateMap<CidadeDTO, Cidade>();

            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Endereco, EnderecoDTO>();
            CreateMap<EnderecoDTO, Endereco>();

            CreateMap<Estado, EstadoDTO>();
            CreateMap<EstadoDTO, Estado>();
            
            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<FuncionarioDTO, Funcionario>();

            CreateMap<Pais, PaisDTO>();
            CreateMap<PaisDTO, Pais>();

            CreateMap<PessoaFisica, PessoaFisicaDTO>();
            CreateMap<PessoaFisicaDTO, PessoaFisica>();

            CreateMap<PessoaJuridica, PessoaJuridicaDTO>();
            CreateMap<PessoaJuridicaDTO, PessoaJuridica>();

            CreateMap<Setor, SetorDTO>();
            CreateMap<SetorDTO, Setor>();

            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();

        }
    }
}
