using System.Collections;
using System.Collections.Generic;

namespace DataAccessLayer.Entitys
{
    public class UsersMeeting
    {
        public int Id { get; set; }
        public virtual ICollection<UserMeetingsInfo> MeetingsInfos { get; set; }
        public string Description { get; set; }
        public UsersMeeting()
        {
            MeetingsInfos = new List<UserMeetingsInfo>();
        }
    }
}