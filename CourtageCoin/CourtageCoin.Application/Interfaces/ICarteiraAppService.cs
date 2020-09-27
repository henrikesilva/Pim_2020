using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface ICarteiraAppService
    {
        void Adicionar(CarteiraDTO carteira);
        CarteiraDTO ObterPorId(int Id);
        IEnumerable<CarteiraDTO> ObterTodos();
        void Atualizar(CarteiraDTO carteira);
        void Remover(CarteiraDTO carteira);
        void Dispose();
    }
}
