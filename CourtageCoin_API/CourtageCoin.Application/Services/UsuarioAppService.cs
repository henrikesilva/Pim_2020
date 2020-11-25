using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CourtageCoin.Application.Services
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper) : base(usuarioService, mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        public Usuario GetUsuario(string login, string senha)
        {
            return _mapper.Map<Usuario>(_usuarioService.Login(login, senha));
        }

        public string Login(Usuario usuario)
        {
            if (usuario != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(Usuario.secret);
                var tokenDescritor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, usuario.USU_STR_LOGIN),
                        new Claim(ClaimTypes.Role, usuario.Perfil.PER_STR_NOME)
                    }),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescritor);
                return tokenHandler.WriteToken(token);
            }
            else
            {
                return null;
            }
        }
    }
}
