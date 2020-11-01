using System.Collections.Generic;

namespace WebDeveloper.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        bool Incluir(TEntity entidade);
        bool Alterar(TEntity entidade);
        bool Excluir(TEntity entidade);
        TEntity Consultar(int Id);
        IEnumerable<TEntity> ConsultarTodos();
        void Dispose();
    }
}
