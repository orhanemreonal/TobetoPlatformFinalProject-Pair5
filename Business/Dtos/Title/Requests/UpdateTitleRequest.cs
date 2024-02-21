namespace Business.Dtos.Title.Requests
{
    public class UpdateTitleRequest
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
        public string Subtype { get; set; }
        public string VideoLanguage { get; set; }
        public string VideoLink { get; set; }
        public int VideoTime { get; set; }
    }
}
