namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelairmaos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Irmaos",
                c => new
                    {
                        IrmaoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        PessoaId = c.Int(nullable: false),
                        Idade = c.String(maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.IrmaoId)
                .ForeignKey("dbo.Atletas", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Irmaos", "PessoaId", "dbo.Atletas");
            DropIndex("dbo.Irmaos", new[] { "PessoaId" });
            DropTable("dbo.Irmaos");
        }
    }
}
