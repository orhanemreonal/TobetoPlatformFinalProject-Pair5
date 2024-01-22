namespace Business.Dtos.Like.Requests
{
    public class CreateLikeRequest
    {
        public Guid CourseId { get; set; }
        public Guid TitleId { get; set; }
    }
}
