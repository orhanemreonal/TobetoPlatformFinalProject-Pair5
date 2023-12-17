namespace Business.Dtos.Exam.Requests
{
    public class CreateExamRequest
    {
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
