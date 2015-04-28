namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelairmaosrevisao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Irmaos", "Numero", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Irmaos", "Numero");
        }
    }
}
