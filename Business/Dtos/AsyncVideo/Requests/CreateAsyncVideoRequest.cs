namespace Business.Dtos.AsyncVideo.Requests
{
    public class CreateAsyncVideoRequest
    {
        public Guid LikeId { get; set; }
        public Guid TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
