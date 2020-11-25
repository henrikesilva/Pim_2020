using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Application.Services
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;
        private readonly IMapper _mapper;

        public EnderecoAppService(IEnderecoService enderecoService, IMapper mapper) : base(enderecoService, mapper)
        {
            _enderecoService = enderecoService;
            _mapper = mapper;
        }
    }
}
