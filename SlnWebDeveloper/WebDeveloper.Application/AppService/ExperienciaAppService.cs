using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Application.AppService
{
    public class ExperienciaAppService : AppServiceBase<Experiencia>, IExperienciaAppService
    {
        private readonly IExperienciaService _experienciaService;

        public ExperienciaAppService(IExperienciaService experienciaService)
            : base(experienciaService)
        {
            _experienciaService = experienciaService;
        }
    }
}
