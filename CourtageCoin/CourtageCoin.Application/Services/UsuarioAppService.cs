using AutoMapper;
using CourtageCoin.Application.DTO.Models;
using CourtageCoin.Application.Interfaces;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        #region [ESCRITA]
        public void Adicionar(UsuarioDTO usuario)
        {
            _usuarioService.Adicionar(_mapper.Map<Usuario>(usuario));
        }

        public void Atualizar(UsuarioDTO usuario)
        {
            _usuarioService.Atualizar(_mapper.Map<Usuario>(usuario));
        }

        public void Remover(UsuarioDTO usuario)
        {
            _usuarioService.Remover(_mapper.Map<Usuario>(usuario));
        }
        #endregion


        #region [CONSULTA]
        public UsuarioDTO ObterPorId(int Id)
        {
            return _mapper.Map<UsuarioDTO>(_usuarioService.GetByID(Id));
        }

        public IEnumerable<UsuarioDTO> ObterTodos()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(_usuarioService.GetAll());
        }
        #endregion

        public void Dispose()
        {
            _usuarioService.Dispose();
        }
    }
}
