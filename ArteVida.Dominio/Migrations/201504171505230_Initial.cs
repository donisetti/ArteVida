namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                        Endereco = c.String(maxLength: 150, unicode: false),
                        Bairro = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Rg = c.String(maxLength: 150, unicode: false),
                        Cpf = c.String(maxLength: 150, unicode: false),
                        Sexo = c.String(maxLength: 150, unicode: false),
                        Idade = c.Int(nullable: false),
                        Telefone = c.String(maxLength: 150, unicode: false),
                        Escola = c.String(maxLength: 150, unicode: false),
                        Serie = c.String(maxLength: 150, unicode: false),
                        Pai = c.String(maxLength: 150, unicode: false),
                        TelefonePai = c.String(maxLength: 150, unicode: false),
                        Mae = c.String(maxLength: 150, unicode: false),
                        TelefoneMae = c.String(maxLength: 150, unicode: false),
                        DataAlteracao = c.DateTime(),
                        DataInativacao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId);
            
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
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Instrutores",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instrutores", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Atletas", "PessoaId", "dbo.Pessoas");
            DropIndex("dbo.Instrutores", new[] { "PessoaId" });
            DropIndex("dbo.Atletas", new[] { "PessoaId" });
            DropTable("dbo.Instrutores");
            DropTable("dbo.Atletas");
            DropTable("dbo.TabelasAuxiliares");
            DropTable("dbo.Pessoas");
        }
    }
}
