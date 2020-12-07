namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cuzin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EspecialidadMedicoes", "Especialidad_IdEspecialidade", "dbo.Especialidads");
            DropForeignKey("dbo.EspecialidadMedicoes", "Medico_IdMedico", "dbo.Medicos");
            DropIndex("dbo.EspecialidadMedicoes", new[] { "Especialidad_IdEspecialidade" });
            DropIndex("dbo.EspecialidadMedicoes", new[] { "Medico_IdMedico" });
            AddColumn("dbo.Medicos", "IdEspecialidade", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicos", "IdEspecialidade");
            AddForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads", "IdEspecialidade", cascadeDelete: true);
            DropTable("dbo.EspecialidadMedicoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EspecialidadMedicoes",
                c => new
                    {
                        Especialidad_IdEspecialidade = c.Int(nullable: false),
                        Medico_IdMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Especialidad_IdEspecialidade, t.Medico_IdMedico });
            
            DropForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "IdEspecialidade" });
            DropColumn("dbo.Medicos", "IdEspecialidade");
            CreateIndex("dbo.EspecialidadMedicoes", "Medico_IdMedico");
            CreateIndex("dbo.EspecialidadMedicoes", "Especialidad_IdEspecialidade");
            AddForeignKey("dbo.EspecialidadMedicoes", "Medico_IdMedico", "dbo.Medicos", "IdMedico", cascadeDelete: true);
            AddForeignKey("dbo.EspecialidadMedicoes", "Especialidad_IdEspecialidade", "dbo.Especialidads", "IdEspecialidade", cascadeDelete: true);
        }
    }
}
