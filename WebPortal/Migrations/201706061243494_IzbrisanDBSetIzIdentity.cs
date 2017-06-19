namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IzbrisanDBSetIzIdentity : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MaterijalModels");
        }
        
        public override void Down()
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
    }
}
