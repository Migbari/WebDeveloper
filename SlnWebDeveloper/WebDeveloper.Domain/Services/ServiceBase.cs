using System;
using System.Collections.Generic;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>, IDisposable where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repositoryBase = repository;
        }
        public bool Alterar(TEntity entidade)
        {
            return _repositoryBase.Alterar(entidade);
        }

        public TEntity Consultar(int id)
        {
            return _repositoryBase.Consultar(id);
        }

        public IEnumerable<TEntity> ConsultarTodos()
        {
            return _repositoryBase.ConsultarTodos();
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public bool Excluir(TEntity entidade)
        {
            return _repositoryBase.Excluir(entidade);
        }

        public bool Incluir(TEntity entidade)
        {
            return _repositoryBase.Incluir(entidade);
        }
    }
}
