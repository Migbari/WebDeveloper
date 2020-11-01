using System.Data.Entity.ModelConfiguration;
using WebDeveloper.Domain.Entities;

namespace WebDeveloper.Infra.Data.EntityConfig
{
    public class TecnologiaConfiguration : EntityTypeConfiguration<Tecnologia>
    {
        public TecnologiaConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
