namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UsersMeetings", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UsersMeetings", "Description");
        }
    }
}
