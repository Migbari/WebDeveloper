using System.Collections.Generic;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;

namespace WebDeveloper.Infra.Data.Repositories
{
    public class DesenvolvedorRepository : RepositoryBase<Desenvolvedor>, IDesenvolvedorRepository
    {
        public IEnumerable<Desenvolvedor> BuscarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }
    }
}
