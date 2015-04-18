namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datanula : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "DataCadastro", c => c.DateTime());
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pessoas", "DataCadastro", c => c.DateTime(nullable: false));
        }
    }
}
