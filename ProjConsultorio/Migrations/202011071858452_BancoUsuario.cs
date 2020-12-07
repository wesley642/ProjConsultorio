namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BancoUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ManutUsers", "Nome", c => c.String());
            AddColumn("dbo.ManutUsers", "SegundoNome", c => c.String());
            AddColumn("dbo.ManutUsers", "SobreNome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ManutUsers", "SobreNome");
            DropColumn("dbo.ManutUsers", "SegundoNome");
            DropColumn("dbo.ManutUsers", "Nome");
        }
    }
}
