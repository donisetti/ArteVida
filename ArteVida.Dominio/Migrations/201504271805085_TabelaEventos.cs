namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaEventos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        EventoId = c.Int(nullable: false, identity: true),
                        DataEvento = c.DateTime(),
                        Nome = c.String(maxLength: 150, unicode: false),
                        Cidade = c.String(maxLength: 150, unicode: false),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        DataInativacao = c.DateTime(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evento");
        }
    }
}
