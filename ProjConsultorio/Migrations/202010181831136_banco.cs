namespace ProjConsultorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        IdMedico = c.Int(nullable: false, identity: true),
                        IdEspecialidade = c.Int(nullable: false),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Telefone = c.String(),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.IdMedico)
                .ForeignKey("dbo.Especialidads", t => t.IdEspecialidade, cascadeDelete: true)
                .Index(t => t.IdEspecialidade);
            
            CreateTable(
                "dbo.Especialidads",
                c => new
                    {
                        IdEspecialidade = c.Int(nullable: false, identity: true),
                        Especialidade = c.String(),
                    })
                .PrimaryKey(t => t.IdEspecialidade);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        IdPaciente = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Telefone = c.String(),
                        CPF = c.String(),
                        Convenio = c.String(),
                        Plano = c.String(),
                        NumCartao = c.String(),
                    })
                .PrimaryKey(t => t.IdPaciente);
            
            AddColumn("dbo.Consultas", "IdMedico", c => c.Int(nullable: false));
            AddColumn("dbo.Consultas", "IdPaciente", c => c.Int(nullable: false));
            CreateIndex("dbo.Consultas", "IdMedico");
            CreateIndex("dbo.Consultas", "IdPaciente");
            AddForeignKey("dbo.Consultas", "IdMedico", "dbo.Medicos", "IdMedico", cascadeDelete: true);
            AddForeignKey("dbo.Consultas", "IdPaciente", "dbo.Pacientes", "IdPaciente", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consultas", "IdPaciente", "dbo.Pacientes");
            DropForeignKey("dbo.Consultas", "IdMedico", "dbo.Medicos");
            DropForeignKey("dbo.Medicos", "IdEspecialidade", "dbo.Especialidads");
            DropIndex("dbo.Medicos", new[] { "IdEspecialidade" });
            DropIndex("dbo.Consultas", new[] { "IdPaciente" });
            DropIndex("dbo.Consultas", new[] { "IdMedico" });
            DropColumn("dbo.Consultas", "IdPaciente");
            DropColumn("dbo.Consultas", "IdMedico");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Especialidads");
            DropTable("dbo.Medicos");
        }
    }
}
