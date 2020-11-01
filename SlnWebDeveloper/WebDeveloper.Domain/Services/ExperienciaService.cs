using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Domain.Services
{
    public class ExperienciaService : ServiceBase<Experiencia>, IExperienciaService
    {
        private readonly IExperienciaRepository _experienciaRepository;

        public ExperienciaService(IExperienciaRepository experienciaRepository)
            : base (experienciaRepository)
        {
            _experienciaRepository = experienciaRepository;
        }
    }
}