using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Domain.Services
{
    public class TecnologiaService : ServiceBase<Tecnologia>, ITecnologiaService
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;

        public TecnologiaService(ITecnologiaRepository tecnologiaRepository)
            : base (tecnologiaRepository)
        {
            _tecnologiaRepository = tecnologiaRepository;
        }
    }
}
