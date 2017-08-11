namespace WebPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaterijalPromenaPart3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaterijalModels", "materijalNaziv", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaterijalModels", "materijalNaziv", c => c.String(nullable: false));
        }
    }
}
