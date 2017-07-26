namespace WebPortal.Migrations.MaterijalContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajPredmet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PredmetModels",
                c => new
                    {
                        predmetId = c.Int(nullable: false, identity: true),
                        predmetNaziv = c.String(),
                        predmetOpis = c.String(),
                    })
                .PrimaryKey(t => t.predmetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PredmetModels");
        }
    }
}
