namespace Business.Dtos.StudentLike.Requests
{
    public class UpdateStudentLikeRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid LikeId { get; set; }
    }
}
