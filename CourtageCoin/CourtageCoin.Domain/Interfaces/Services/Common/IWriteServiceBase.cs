namespace CourtageCoin.Domain.Interfaces.Services.Write.Common
{
    public interface IWriteServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
