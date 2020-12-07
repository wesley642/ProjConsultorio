namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Medicos", name: "Especialidad_IdEspecialidade", newName: "IdEspecialidade_IdEspecialidade");
            RenameIndex(table: "dbo.Medicos", name: "IX_Especialidad_IdEspecialidade", newName: "IX_IdEspecialidade_IdEspecialidade");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Medicos", name: "IX_IdEspecialidade_IdEspecialidade", newName: "IX_Especialidad_IdEspecialidade");
            RenameColumn(table: "dbo.Medicos", name: "IdEspecialidade_IdEspecialidade", newName: "Especialidad_IdEspecialidade");
        }
    }
}
