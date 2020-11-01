using System;

namespace WebDeveloper.Domain.Entities
{
    public class Experiencia
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
