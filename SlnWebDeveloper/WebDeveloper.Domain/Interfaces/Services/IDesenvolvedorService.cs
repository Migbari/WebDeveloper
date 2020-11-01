using System.Collections.Generic;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.Domain.Interfaces.Services
{
    public interface IDesenvolvedorService : IServiceBase<Desenvolvedor>
    {
        IEnumerable<Desenvolvedor> BuscarPorNome(string nome);
    }
}
