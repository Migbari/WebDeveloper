using System.Collections.Generic;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.Domain.Interfaces.Repositories
{
    public interface IDesenvolvedorRepository : IRepositoryBase<Desenvolvedor> 
    {
        IEnumerable<Desenvolvedor> BuscarPorNome(string nome);
    }
}
