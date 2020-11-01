using System.Collections.Generic;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Domain.Services
{
    public class DesenvolvedorService : ServiceBase<Desenvolvedor>, IDesenvolvedorService
    {
        private readonly IDesenvolvedorRepository _desenvolvedorRepository;

        public DesenvolvedorService(IDesenvolvedorRepository desenvolvedorRepository)
            : base(desenvolvedorRepository)
        {
            _desenvolvedorRepository = desenvolvedorRepository;
        }

        public IEnumerable<Desenvolvedor> BuscarPorNome(string nome)
        {
            return _desenvolvedorRepository.BuscarPorNome(nome);
        }
    }
}
