namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Revisao12a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atletas", "Foto", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Evento", "Local", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Evento", "Local");
            DropColumn("dbo.Atletas", "Foto");
        }
    }
}
