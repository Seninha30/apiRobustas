using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XGameConnectionString")
        {

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false; // true faz com que o entity carregue objetos encadeados
        }

        public IDbSet<Jogador> Jogadores { get; set; }

        public IDbSet<Plataforma> Plataformas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Seta o Schema default
            //modelBuilder.HasDefaultSchema("Apoio");

            //Remove pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar varchar ao invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //caso eu esqueça de colocar o tamanho do campo, ele coloca para mim este valor
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Mapeia as entidades
            //modelBuilder.Configurations.Add(new VeiculoMap());

            #region Adiciona entidades mapeadas automaticamente  via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
