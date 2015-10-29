namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Revisao12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        NumeroFicha = c.String(maxLength: 150, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Email = c.String(maxLength: 150, unicode: false),
                        Endereco = c.String(maxLength: 150, unicode: false),
                        Bairro = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        Estado = c.String(maxLength: 150, unicode: false),
                        DataNascimento = c.DateTime(),
                        Rg = c.String(maxLength: 150, unicode: false),
                        Cpf = c.String(maxLength: 150, unicode: false),
                        Sexo = c.String(maxLength: 150, unicode: false),
                        Idade = c.Int(),
                        Telefone = c.String(maxLength: 150, unicode: false),
                        Escola = c.String(maxLength: 150, unicode: false),
                        Serie = c.String(maxLength: 150, unicode: false),
                        Pai = c.String(maxLength: 150, unicode: false),
                        TelefonePai = c.String(maxLength: 150, unicode: false),
                        Mae = c.String(maxLength: 150, unicode: false),
                        TelefoneMae = c.String(maxLength: 150, unicode: false),
                        Tipo = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        DataInativacao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                        Discriminator = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        EventoId = c.Int(nullable: false, identity: true),
                        DataEvento = c.DateTime(),
                        Nome = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        Modalidade = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        DataInativacao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventoId);
            
            CreateTable(
                "dbo.Irmaos",
                c => new
                    {
                        IrmaoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Numero = c.String(maxLength: 150, unicode: false),
                        PessoaId = c.Int(nullable: false),
                        Idade = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.IrmaoId)
                .ForeignKey("dbo.Atletas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.TabelasAuxiliares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 150, unicode: false),
                        Tipo = c.String(maxLength: 150, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        DataInativacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Atletas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Modalidade = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Instrutores",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Atividade = c.String(maxLength: 150, unicode: false),
                        Profissao = c.String(maxLength: 150, unicode: false),
                        Observacao = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instrutores", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Atletas", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Irmaos", "PessoaId", "dbo.Atletas");
            DropIndex("dbo.Instrutores", new[] { "PessoaId" });
            DropIndex("dbo.Atletas", new[] { "PessoaId" });
            DropIndex("dbo.Irmaos", new[] { "PessoaId" });
            DropTable("dbo.Instrutores");
            DropTable("dbo.Atletas");
            DropTable("dbo.TabelasAuxiliares");
            DropTable("dbo.Irmaos");
            DropTable("dbo.Evento");
            DropTable("dbo.Pessoas");
        }
    }
}
