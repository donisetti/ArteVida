namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevisaoInstrutorPessoanulos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Idade", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Idade", c => c.Int(nullable: false));
        }
    }
}
