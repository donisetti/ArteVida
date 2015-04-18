namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revisao01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Estado", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Estado");
        }
    }
}
