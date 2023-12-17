namespace Business.Dtos.Exam.Requests
{
    public class UpdateExamRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
