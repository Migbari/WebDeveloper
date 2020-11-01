using System;
using System.Collections.Generic;
using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Application.AppService
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity>, IDisposable where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public bool Alterar(TEntity entidade)
        {
            return _serviceBase.Alterar(entidade);
        }

        public TEntity Consultar(int Id)
        {
            return _serviceBase.Consultar(Id);
        }

        public IEnumerable<TEntity> ConsultarTodos()
        {
            return _serviceBase.ConsultarTodos();
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public bool Excluir(TEntity entidade)
        {
            return _serviceBase.Excluir(entidade);
        }

        public bool Incluir(TEntity entidade)
        {
            return _serviceBase.Incluir(entidade);
        }
    }
}
