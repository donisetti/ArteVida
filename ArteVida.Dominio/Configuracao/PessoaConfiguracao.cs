using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Configuracao
{
    public class PessoaConfiguracao : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguracao()
        {
            ToTable("Pessoas");
            HasKey(p => p.PessoaId);

            Property(p => p.PessoaId)
            .HasColumnName("PessoaId")
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(250);


        }

    }


    public class IrmaoConfiguracao : EntityTypeConfiguration<Irmao>
    {
        public IrmaoConfiguracao()
        {
            ToTable("Irmaos");

            HasKey(p => p.IrmaoId);

            Property(p => p.IrmaoId)
            .HasColumnName("IrmaoId")
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(250);


        }
    }

    public class AtletaConfiguracao : EntityTypeConfiguration<Atleta>
    {
        public AtletaConfiguracao()
        {
            ToTable("Atletas");
        }
    }

    public class InstrutorConfiguracao : EntityTypeConfiguration<Instrutor>
    {
        public InstrutorConfiguracao()
        {
            ToTable("Instrutores");
        }
    }

    public class EmrpesaConfiguracao : EntityTypeConfiguration<Empresa>
    {
        public EmrpesaConfiguracao()
        {
            ToTable("Empresas");
        }
    }
}
