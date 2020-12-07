namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicos", "Especialidad_IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "Especialidad_IdEspecialidade" });
            RenameColumn(table: "dbo.Medicos", name: "Especialidad_IdEspecialidade", newName: "IdEspecialidade");
            AlterColumn("dbo.Medicos", "IdEspecialidade", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicos", "IdEspecialidade");
            AddForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads", "IdEspecialidade", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "IdEspecialidade" });
            AlterColumn("dbo.Medicos", "IdEspecialidade", c => c.Int());
            RenameColumn(table: "dbo.Medicos", name: "IdEspecialidade", newName: "Especialidad_IdEspecialidade");
            CreateIndex("dbo.Medicos", "Especialidad_IdEspecialidade");
            AddForeignKey("dbo.Medicos", "Especialidad_IdEspecialidade", "dbo.Especialidads", "IdEspecialidade");
        }
    }
}
