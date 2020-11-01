using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Domain.Interfaces.Services
{
   public interface IServiceBase<TEntity> where TEntity : class
    {
        bool Incluir(TEntity entidade);
        bool Alterar(TEntity entidade);
        bool Excluir(TEntity entidade);
        TEntity Consultar(int Id);
        IEnumerable<TEntity> ConsultarTodos();
        void Dispose();
    }
}
