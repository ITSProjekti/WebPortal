namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromenaMaterijalModela : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaterijalModels", "materijalUrl", c => c.String());
            AlterColumn("dbo.MaterijalModels", "materijalTip", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaterijalModels", "materijalTip", c => c.String(nullable: false));
            AlterColumn("dbo.MaterijalModels", "materijalUrl", c => c.String(nullable: false));
        }
    }
}
