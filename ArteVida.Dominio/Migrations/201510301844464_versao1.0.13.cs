namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao1013 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atletas", "Cbat", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Cep", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "TelefoneResidencial", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "TelefoneComercial", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "TelefoneCelular", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Profissao", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "RazaoSocial", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Cnpj", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Logo", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Responsavel", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Atividade1", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "TelefoneResponsavel", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "CelularResponsavel", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "DataAdesao", c => c.DateTime());
            AddColumn("dbo.Pessoas", "Mensalidade", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Pessoas", "DataAdesao1", c => c.DateTime());
            AddColumn("dbo.Pessoas", "Mensalidade1", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Pessoas", "Empresa", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Atividade2", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Periodo", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "DiaSemana", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Motivacao", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Instrutores", "Faculdade", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Instrutores", "Cref", c => c.String(maxLength: 150, unicode: false));
            DropColumn("dbo.Instrutores", "Profissao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instrutores", "Profissao", c => c.String(maxLength: 150, unicode: false));
            DropColumn("dbo.Instrutores", "Cref");
            DropColumn("dbo.Instrutores", "Faculdade");
            DropColumn("dbo.Pessoas", "Motivacao");
            DropColumn("dbo.Pessoas", "DiaSemana");
            DropColumn("dbo.Pessoas", "Periodo");
            DropColumn("dbo.Pessoas", "Atividade2");
            DropColumn("dbo.Pessoas", "Empresa");
            DropColumn("dbo.Pessoas", "Mensalidade1");
            DropColumn("dbo.Pessoas", "DataAdesao1");
            DropColumn("dbo.Pessoas", "Mensalidade");
            DropColumn("dbo.Pessoas", "DataAdesao");
            DropColumn("dbo.Pessoas", "CelularResponsavel");
            DropColumn("dbo.Pessoas", "TelefoneResponsavel");
            DropColumn("dbo.Pessoas", "Atividade1");
            DropColumn("dbo.Pessoas", "Responsavel");
            DropColumn("dbo.Pessoas", "Logo");
            DropColumn("dbo.Pessoas", "Cnpj");
            DropColumn("dbo.Pessoas", "RazaoSocial");
            DropColumn("dbo.Pessoas", "Profissao");
            DropColumn("dbo.Pessoas", "TelefoneCelular");
            DropColumn("dbo.Pessoas", "TelefoneComercial");
            DropColumn("dbo.Pessoas", "TelefoneResidencial");
            DropColumn("dbo.Pessoas", "Cep");
            DropColumn("dbo.Atletas", "Cbat");
        }
    }
}
