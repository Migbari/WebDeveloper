using System;
using System.Collections.Generic;

namespace WebDeveloper.Domain.Entities
{
    public class Desenvolvedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte[] Avatar { get; set; }
        public string Biografia { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Tecnologia> Tecnologias { get; set; }
        public Senioridade Senioridade { get; set; }
    }
}
