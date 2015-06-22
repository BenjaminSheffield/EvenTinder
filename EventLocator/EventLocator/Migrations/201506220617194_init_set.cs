namespace EventLocator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_set : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "images");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "images", c => c.String());
        }
    }
}
