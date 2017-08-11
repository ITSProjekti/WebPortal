namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromenaMaterijalModelaPart2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterijalModels", "materijalFile", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MaterijalModels", "materijalFile");
        }
    }
}
