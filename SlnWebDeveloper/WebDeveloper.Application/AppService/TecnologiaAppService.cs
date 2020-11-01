using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Application.AppService
{
    public class TecnologiaAppService : AppServiceBase<Tecnologia>, ITecnologiaAppService
    {
        private readonly ITecnologiaService _tecnologiaService;

        public TecnologiaAppService(ITecnologiaService tecnologiaService)
            : base(tecnologiaService)
        {
            _tecnologiaService = tecnologiaService;
        }
    }
}
