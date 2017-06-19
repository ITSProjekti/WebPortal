namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaterijalModelMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterijalModels",
                c => new
                    {
                        materijalId = c.Int(nullable: false, identity: true),
                        materijalUrl = c.String(nullable: false),
                        materijalTip = c.String(nullable: false),
                        materijalNaziv = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.materijalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaterijalModels");
        }
    }
}
