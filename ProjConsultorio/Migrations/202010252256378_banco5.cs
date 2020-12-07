namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "IdEspecialidade" });
            RenameColumn(table: "dbo.Medicos", name: "IdEspecialidade", newName: "Especialidad_IdEspecialidade");
            AlterColumn("dbo.Medicos", "Especialidad_IdEspecialidade", c => c.Int());
            CreateIndex("dbo.Medicos", "Especialidad_IdEspecialidade");
            AddForeignKey("dbo.Medicos", "Especialidad_IdEspecialidade", "dbo.Especialidads", "IdEspecialidade");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicos", "Especialidad_IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "Especialidad_IdEspecialidade" });
            AlterColumn("dbo.Medicos", "Especialidad_IdEspecialidade", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Medicos", name: "Especialidad_IdEspecialidade", newName: "IdEspecialidade");
            CreateIndex("dbo.Medicos", "IdEspecialidade");
            AddForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads", "IdEspecialidade", cascadeDelete: true);
        }
    }
}
