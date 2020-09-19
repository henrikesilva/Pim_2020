using CourtageCoin.Services.DTO.Models;

namespace CourtageCoin.Services.Interfaces
{
    public interface IRelatorioAppServices
    {
        int InserirRelatorio(RelatorioDTO relatorio);
        int EditarRelatorio(int CodigoRelatorio);
        RelatorioDTO ConsultarRelatorio(int CodigoRelatorio);
    }
}
