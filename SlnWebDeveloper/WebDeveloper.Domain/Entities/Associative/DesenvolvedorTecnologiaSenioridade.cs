using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Domain.Entities.Associative
{
    public class DesenvolvedorTecnologiaSenioridade
    {
        public int Id { get; set; }
        public int DesenvolvedorId { get; set; }
        public int TecnologiaId { get; set; }
        public int SenioridadeId { get; set; }
        public virtual Desenvolvedor Desenvolvedor { get; set; }
        public virtual Tecnologia Tecnologia { get; set; }
        public virtual Senioridade Senioridade { get; set; }
        public DateTime InicioExperiencia { get; set; }
    }
}
