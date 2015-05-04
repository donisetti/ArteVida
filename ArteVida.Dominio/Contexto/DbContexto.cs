using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using ArteVida.Dominio.Configuracao;
using ArteVida.Dominio.Entidades;
using ArteVida.Dominio.Repositorio;

namespace ArteVida.Dominio.Contexto
{
    public class DbContexto : DbContext, IUnitOfWork
    {

        public DbContexto()
            : base("ArteVidaDbContexto")
        {
                    #if DEBUG
                         //       Database.SetInitializer(new CriarNovoBd());
                    #endif

                     //        Database.SetInitializer(new CriarNovoBd());
        }



        // Corretora
        public DbSet<TabelaAuxiliar> TabelasAuxiliares { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Atleta> Atletas { get; set; }

        public DbSet<Irmao> Irmoes { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Evento> Eventos { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Properties()
                .Where(p => p.ReflectedType != null && p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));

            modelBuilder.Configurations.Add(new PessoaConfiguracao());
            //modelBuilder.Configurations.Add(new PessoaFisicaConfiguracao());
            //modelBuilder.Configurations.Add(new PessoaJuridicaConfiguracao());
            modelBuilder.Configurations.Add(new AtletaConfiguracao());
            modelBuilder.Configurations.Add(new InstrutorConfiguracao());
            modelBuilder.Configurations.Add(new IrmaoConfiguracao());




        }


        public int Commit()
        {
            try
            {
                return SaveChanges();
            }
            catch (Exception erro)
            {

                throw new EntityException("Falha banco de dados: " + erro.Message);
            }
        }

        public Task CommitAsync()
        {
            return SaveChangesAsync();
        }

        public void Rollback()
        {
            ChangeTracker.Entries().ToList().ForEach(entry => entry.State = EntityState.Unchanged);
        }


    }
}
