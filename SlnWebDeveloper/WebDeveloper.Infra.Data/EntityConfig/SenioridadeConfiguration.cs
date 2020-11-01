using System.Data.Entity.ModelConfiguration;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.Infra.Data.EntityConfig
{
    public class SenioridadeConfiguration : EntityTypeConfiguration<Senioridade>
    {
        public SenioridadeConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
