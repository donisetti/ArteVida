namespace ArteVida.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevisaoInstrutor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instrutores", "Atividade", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Instrutores", "Profissao", c => c.String(maxLength: 150, unicode: false));
            AddColumn("dbo.Instrutores", "Observacao", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instrutores", "Observacao");
            DropColumn("dbo.Instrutores", "Profissao");
            DropColumn("dbo.Instrutores", "Atividade");
        }
    }
}
