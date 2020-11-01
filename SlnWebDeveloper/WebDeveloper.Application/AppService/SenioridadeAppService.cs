using WebDeveloper.Application.Interface;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Application.AppService
{
    public class SenioridadeAppService : AppServiceBase<Senioridade>, ISenioridadeAppService
    {
        private readonly ISenioridadeService _senioridadeService;

        public SenioridadeAppService(ISenioridadeService senioridadeService)
            : base(senioridadeService)
        {
            _senioridadeService = senioridadeService;
        }
    }
}
