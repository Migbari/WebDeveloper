using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Application.AppService
{
    public class DesenvolvedorAppService : AppServiceBase<Desenvolvedor>, IDesenvolvedorAppService
    {
        private readonly IDesenvolvedorService _desenvolvedorService;

        public DesenvolvedorAppService(IDesenvolvedorService desenvolvedorService)
            : base (desenvolvedorService)
        {
            _desenvolvedorService = desenvolvedorService;
        }
    }
}
