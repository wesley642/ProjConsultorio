namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "CEP", c => c.String());
            AddColumn("dbo.Pacientes", "Rua", c => c.String());
            AddColumn("dbo.Pacientes", "Bairro", c => c.String());
            AddColumn("dbo.Pacientes", "Cidade", c => c.String());
            AddColumn("dbo.Pacientes", "Estado", c => c.String());
            DropColumn("dbo.Pacientes", "Endereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "Endereco", c => c.String());
            DropColumn("dbo.Pacientes", "Estado");
            DropColumn("dbo.Pacientes", "Cidade");
            DropColumn("dbo.Pacientes", "Bairro");
            DropColumn("dbo.Pacientes", "Rua");
            DropColumn("dbo.Pacientes", "CEP");
        }
    }
}
