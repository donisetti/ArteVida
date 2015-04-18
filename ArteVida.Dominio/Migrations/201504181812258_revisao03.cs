namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revisao03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atletas", "Modalidade", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Tipo", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Pessoas", "Discriminator", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Discriminator");
            DropColumn("dbo.Pessoas", "Tipo");
            DropColumn("dbo.Atletas", "Modalidade");
        }
    }
}
