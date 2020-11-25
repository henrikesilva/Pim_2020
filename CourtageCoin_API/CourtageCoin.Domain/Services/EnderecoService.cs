using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
