namespace Business.Dtos.Announcement.Requests
{
    public class CreateAnnouncementRequest
    {
        public string Type { get; set; }
        public string Organization { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsRead { get; set; }
    }
}
