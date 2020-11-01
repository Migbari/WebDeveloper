using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Infra.Data.Context;

namespace WebDeveloper.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DBContext db = new DBContext();
        public bool Alterar(TEntity entidade)
        {
            db.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return true;
        }

        public TEntity Consultar(int Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ConsultarTodos()
        {
            return db.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public bool Excluir(TEntity entidade)
        {
            try
            {
                db.Set<TEntity>().Remove(entidade);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Incluir(TEntity entidade)
        {
            try
            {
                db.Set<TEntity>().Add(entidade);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
