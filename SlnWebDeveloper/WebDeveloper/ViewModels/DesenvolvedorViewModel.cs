using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.ViewModels
{
    public class DesenvolvedorViewModel
    {   
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(15, ErrorMessage = "Máximo de 15 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Sobrenome { get; set; }
        public byte[] Avatar { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Biografia { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Tecnologia> Tecnologias { get; set; }
        public Senioridade Senioridade { get; set; }
    }
}