namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevisaoInstrutorPessoa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Email", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Email");
        }
    }
}
