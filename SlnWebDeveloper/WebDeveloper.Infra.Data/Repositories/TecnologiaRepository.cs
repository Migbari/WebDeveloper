using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Interfaces.Repositories;

namespace WebDeveloper.Infra.Data.Repositories
{
    public class TecnologiaRepository : RepositoryBase<Tecnologia>, ITecnologiaRepository
    {
    }
}
