namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaEventos2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evento", "Modalidade", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Evento", "Modalidade");
        }
    }
}
