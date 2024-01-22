namespace Business.Dtos.Like.Requests
{
    public class UpdateLikeRequest
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid TitleId { get; set; }
    }
}
