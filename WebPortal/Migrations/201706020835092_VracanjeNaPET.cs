namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VracanjeNaPET : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MaterijalModels", "materijalFile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterijalModels", "materijalFile", c => c.Binary(nullable: false));
        }
    }
}
