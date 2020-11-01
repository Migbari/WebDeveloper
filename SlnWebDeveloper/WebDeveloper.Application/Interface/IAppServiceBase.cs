using System.Collections.Generic;

namespace WebDeveloper.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        bool Incluir(TEntity entidade);
        bool Alterar(TEntity entidade);
        bool Excluir(TEntity entidade);
        TEntity Consultar(int Id);
        IEnumerable<TEntity> ConsultarTodos();
        void Dispose();
    }
}
