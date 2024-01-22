namespace Business.Dtos.AsyncVideo.Responses
{
    public class GetAsyncVideoResponse
    {
        public Guid Id { get; set; }
        public Guid LikeId { get; set; }
        public Guid TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
