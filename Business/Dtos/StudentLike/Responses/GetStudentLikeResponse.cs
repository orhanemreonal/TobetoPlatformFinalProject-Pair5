namespace Business.Dtos.StudentLike.Responses
{
    public class GetStudentLikeResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid LikeId { get; set; }
    }
}
