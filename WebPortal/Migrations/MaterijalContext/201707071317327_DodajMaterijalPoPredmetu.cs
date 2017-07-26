namespace WebPortal.Migrations.MaterijalContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajMaterijalPoPredmetu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterijalPoPredmetus",
                c => new
                    {
                        MaterijalModelId = c.Int(nullable: false),
                        PredmetModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaterijalModelId, t.PredmetModelId })
                .ForeignKey("dbo.MaterijalModels", t => t.MaterijalModelId, cascadeDelete: true)
                .ForeignKey("dbo.PredmetModels", t => t.PredmetModelId, cascadeDelete: true)
                .Index(t => t.MaterijalModelId)
                .Index(t => t.PredmetModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterijalPoPredmetus", "PredmetModelId", "dbo.PredmetModels");
            DropForeignKey("dbo.MaterijalPoPredmetus", "MaterijalModelId", "dbo.MaterijalModels");
            DropIndex("dbo.MaterijalPoPredmetus", new[] { "PredmetModelId" });
            DropIndex("dbo.MaterijalPoPredmetus", new[] { "MaterijalModelId" });
            DropTable("dbo.MaterijalPoPredmetus");
        }
    }
}
