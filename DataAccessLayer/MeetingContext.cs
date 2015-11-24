using System.Data.Entity;
using DataAccessLayer.Entitys;

namespace DataAccessLayer
{
    public class MeetingContext : ApplicationDbContext
    {

        public DbSet<UserMeetingsInfo> UserMeetingInfos { get; set; }    
        public DbSet<UsersMeeting> UsersMeetings { get; set; }    
//        public DbSet<UserMeetingInfo> UserMeetingInfos { get; set; }    
    }
}