namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterijalModels",
                c => new
                    {
                        materijalId = c.Int(nullable: false, identity: true),
                        materijalFile = c.Binary(),
                        fileMimeType = c.String(),
                        materijalEkstenzija = c.String(),
                        materijalNaziv = c.String(),
                    })
                .PrimaryKey(t => t.materijalId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaterijalModels");
        }
    }
}
