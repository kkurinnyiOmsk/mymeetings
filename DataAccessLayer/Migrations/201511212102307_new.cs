namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMeetingsInfoes", "longitude", c => c.Double(nullable: false));
            AddColumn("dbo.UserMeetingsInfoes", "latitude", c => c.Double(nullable: false));
            AddColumn("dbo.UserMeetingsInfoes", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.UsersMeetings", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserMeetingsInfoes", "User_Id");
            CreateIndex("dbo.UsersMeetings", "ApplicationUser_Id");
            AddForeignKey("dbo.UserMeetingsInfoes", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UsersMeetings", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersMeetings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserMeetingsInfoes", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UsersMeetings", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UserMeetingsInfoes", new[] { "User_Id" });
            DropColumn("dbo.UsersMeetings", "ApplicationUser_Id");
            DropColumn("dbo.UserMeetingsInfoes", "User_Id");
            DropColumn("dbo.UserMeetingsInfoes", "latitude");
            DropColumn("dbo.UserMeetingsInfoes", "longitude");
        }
    }
}
