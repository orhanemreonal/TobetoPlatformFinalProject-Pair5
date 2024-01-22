namespace Business.Dtos.StudentLike.Requests
{
    public class CreateStudentLikeRequest
    {
        public Guid StudentId { get; set; }
        public Guid LikeId { get; set; }
    }
}
