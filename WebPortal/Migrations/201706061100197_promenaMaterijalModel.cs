namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promenaMaterijalModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MaterijalModels", "materijalFile", c => c.Binary());
            AddColumn("dbo.MaterijalModels", "fileMimeType", c => c.String());
            AddColumn("dbo.MaterijalModels", "opisMaterijal", c => c.String());
            AddColumn("dbo.MaterijalModels", "materijalEkstenzija", c => c.String());
            DropColumn("dbo.MaterijalModels", "materijalUrl");
            DropColumn("dbo.MaterijalModels", "materijalTip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterijalModels", "materijalTip", c => c.String());
            AddColumn("dbo.MaterijalModels", "materijalUrl", c => c.String());
            DropColumn("dbo.MaterijalModels", "materijalEkstenzija");
            DropColumn("dbo.MaterijalModels", "opisMaterijal");
            DropColumn("dbo.MaterijalModels", "fileMimeType");
            DropColumn("dbo.MaterijalModels", "materijalFile");
        }
    }
}
