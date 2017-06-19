namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IskomentarisanOpisMaterijala : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MaterijalModels", "opisMaterijal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MaterijalModels", "opisMaterijal", c => c.String());
        }
    }
}
