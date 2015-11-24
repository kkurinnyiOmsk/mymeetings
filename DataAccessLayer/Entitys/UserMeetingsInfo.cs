namespace DataAccessLayer.Entitys
{
    public class UserMeetingsInfo
    {
        public int Id { get; set; }
        //долгота
        public double longitude { get; set; }
        //широта
        public double latitude { get; set; }
        public UsersMeeting UsersMeeting { get; set; }
        public ApplicationUser User { get; set; }
    }
}