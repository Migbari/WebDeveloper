using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;
using WebDeveloper.Domain.Interfaces.Services;

namespace WebDeveloper.Domain.Services
{
    public class SenioridadeService : ServiceBase<Senioridade>, ISenioridadeService
    {
        private readonly ISenioridadeRepository _senioridadeRepository;

        public SenioridadeService(ISenioridadeRepository senioridadeRepository)
           : base(senioridadeRepository)
        {
            _senioridadeRepository = senioridadeRepository;
        }
    }
}
