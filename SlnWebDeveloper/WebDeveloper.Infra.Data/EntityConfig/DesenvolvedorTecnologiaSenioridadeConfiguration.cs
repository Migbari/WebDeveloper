using System.Data.Entity.ModelConfiguration;
using WebDeveloper.Domain.Entities.Associative;

namespace WebDeveloper.Infra.Data.EntityConfig
{
    public class DesenvolvedorTecnologiaSenioridadeConfiguration : EntityTypeConfiguration<DesenvolvedorTecnologiaSenioridade>
    {
        public DesenvolvedorTecnologiaSenioridadeConfiguration()
        {
            HasRequired(p => p.Tecnologia)
                .WithMany()
                .HasForeignKey(p => p.TecnologiaId);

            HasRequired(p => p.Desenvolvedor)
                .WithMany()
                .HasForeignKey(p => p.DesenvolvedorId);

            HasRequired(p => p.Senioridade)
                .WithMany()
                .HasForeignKey(p => p.SenioridadeId);
        }
    }
}
