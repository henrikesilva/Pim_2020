using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Application.Services
{
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        private readonly IFuncionarioService _funcionarioService;
        private readonly IMapper _mapper;

        public FuncionarioAppService(IFuncionarioService funcionarioService, IMapper mapper) : base(funcionarioService, mapper)
        {
            _funcionarioService = funcionarioService;
            _mapper = mapper;
        }
    }
}
