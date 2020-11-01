using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using WebDeveloper.Domain.Entities;
using WebDeveloper.Domain.Entities.Associative;
using WebDeveloper.Infra.Data.EntityConfig;

namespace WebDeveloper.Infra.Data.Context
{
    public class DBContext : DbContext
    {   
        public DbSet<Desenvolvedor> Desenvolvedor { get; set; }
        public DbSet<Experiencia> Experiencia { get; set; }
        public DbSet<Senioridade> Senioridade { get; set; }
        public DbSet<Tecnologia> Tecnologia { get; set; }
        public DbSet<DesenvolvedorTecnologiaSenioridade> DesenvolvedorTecnologiaSenioridade { get; set; }

        public DBContext() : base("StrCnxWebDeveloper")
        {
            Database.SetInitializer<DBContext>(new CreateDatabaseIfNotExists<DBContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
             .Where(p => p.Name == p.ReflectedType + "Id")
             .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
              .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new DesenvolvedorConfiguration());
            modelBuilder.Configurations.Add(new TecnologiaConfiguration());
            modelBuilder.Configurations.Add(new DesenvolvedorTecnologiaSenioridadeConfiguration());
            modelBuilder.Configurations.Add(new SenioridadeConfiguration());
        }
        public override int SaveChanges()
        {   
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
