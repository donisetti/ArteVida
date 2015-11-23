namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao14 : DbMigration
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
                        Cep = c.String(maxLength: 150, unicode: false),
                        Endereco = c.String(maxLength: 150, unicode: false),
                        Bairro = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        Estado = c.String(maxLength: 150, unicode: false),
                        DataNascimento = c.DateTime(precision: 0),
                        Rg = c.String(maxLength: 150, unicode: false),
                        Cpf = c.String(maxLength: 150, unicode: false),
                        Sexo = c.String(maxLength: 150, unicode: false),
                        Idade = c.Int(),
                        Telefone = c.String(maxLength: 150, unicode: false),
                        TelefoneResidencial = c.String(maxLength: 150, unicode: false),
                        TelefoneComercial = c.String(maxLength: 150, unicode: false),
                        TelefoneCelular = c.String(maxLength: 150, unicode: false),
                        Escola = c.String(maxLength: 150, unicode: false),
                        Serie = c.String(maxLength: 150, unicode: false),
                        Pai = c.String(maxLength: 150, unicode: false),
                        TelefonePai = c.String(maxLength: 150, unicode: false),
                        Mae = c.String(maxLength: 150, unicode: false),
                        TelefoneMae = c.String(maxLength: 150, unicode: false),
                        Profissao = c.String(maxLength: 150, unicode: false),
                        Tipo = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(precision: 0),
                        DataAlteracao = c.DateTime(precision: 0),
                        DataInativacao = c.DateTime(precision: 0),
                        Ativo = c.Boolean(nullable: false),
                        RazaoSocial = c.String(maxLength: 150, unicode: false),
                        Cnpj = c.String(maxLength: 150, unicode: false),
                        Logo = c.String(maxLength: 150, unicode: false),
                        Responsavel = c.String(maxLength: 150, unicode: false),
                        Atividade1 = c.String(maxLength: 150, unicode: false),
                        TelefoneResponsavel = c.String(maxLength: 150, unicode: false),
                        CelularResponsavel = c.String(maxLength: 150, unicode: false),
                        DataAdesao = c.DateTime(precision: 0),
                        Mensalidade = c.Decimal(precision: 18, scale: 2),
                        DataAdesao1 = c.DateTime(precision: 0),
                        Mensalidade1 = c.Decimal(precision: 18, scale: 2),
                        Empresa = c.String(maxLength: 150, unicode: false),
                        Atividade2 = c.String(maxLength: 150, unicode: false),
                        Periodo = c.String(maxLength: 150, unicode: false),
                        DiaSemana = c.String(maxLength: 150, unicode: false),
                        Motivacao = c.String(maxLength: 150, unicode: false),
                        Discriminator = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        EventoId = c.Int(nullable: false, identity: true),
                        DataEvento = c.DateTime(precision: 0),
                        Nome = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        Local = c.String(maxLength: 150, unicode: false),
                        Modalidade = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(precision: 0),
                        DataAlteracao = c.DateTime(precision: 0),
                        DataInativacao = c.DateTime(precision: 0),
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
                        DataCadastro = c.DateTime(precision: 0),
                        DataAlteracao = c.DateTime(precision: 0),
                        DataInativacao = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Atletas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Modalidade = c.String(maxLength: 150, unicode: false),
                        Cbat = c.String(maxLength: 150, unicode: false),
                        Foto = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Instrutores",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Faculdade = c.String(maxLength: 150, unicode: false),
                        Atividade = c.String(maxLength: 150, unicode: false),
                        Cref = c.String(maxLength: 150, unicode: false),
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
