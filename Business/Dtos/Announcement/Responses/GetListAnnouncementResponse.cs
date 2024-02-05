namespace Business.Dtos.Announcement.Responses
{
    public class GetListAnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Organization { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public bool? IsRead { get; set; }
    }
}
