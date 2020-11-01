using System.Data.Entity.ModelConfiguration;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.Infra.Data.EntityConfig
{
    public class DesenvolvedorConfiguration : EntityTypeConfiguration<Desenvolvedor>
    {
        public DesenvolvedorConfiguration()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(15);

            Property(d => d.Sobrenome)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.Biografia)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
