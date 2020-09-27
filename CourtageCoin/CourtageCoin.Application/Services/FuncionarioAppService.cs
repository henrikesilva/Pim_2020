using AutoMapper;
using CourtageCoin.Application.DTO.Models;
using CourtageCoin.Application.Interfaces;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class FuncionarioAppService : IFuncionarioAppService
    {
        private readonly IFuncionarioService _funcionarioService;
        private readonly IMapper _mapper;

        public FuncionarioAppService(IFuncionarioService funcionarioService, IMapper mapper)
        {
            _funcionarioService = funcionarioService;
            _mapper = mapper;
        }

        #region [ESCRITA]
        public void Adicionar(FuncionarioDTO funcionario)
        {
            _funcionarioService.Adicionar(_mapper.Map<Funcionario>(funcionario));
        }

        public void Atualizar(FuncionarioDTO funcionario)
        {
            _funcionarioService.Atualizar(_mapper.Map<Funcionario>(funcionario));
        }

        public void Remover(FuncionarioDTO funcionario)
        {
            _funcionarioService.Remover(_mapper.Map<Funcionario>(funcionario));
        }
        #endregion

        #region [CONSULTA]
        public FuncionarioDTO ObterPorId(int Id)
        {
            return _mapper.Map<FuncionarioDTO>(_funcionarioService.GetByID(Id));
        }

        public IEnumerable<FuncionarioDTO> ObterTodos()
        {
            return _mapper.Map<IEnumerable<FuncionarioDTO>>(_funcionarioService.GetAll());
        }
        #endregion

        public void Dispose()
        {
            _funcionarioService.Dispose();
        }
    }
}
