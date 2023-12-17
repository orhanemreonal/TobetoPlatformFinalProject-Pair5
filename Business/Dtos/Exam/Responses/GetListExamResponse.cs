namespace Business.Dtos.Exam.Responses
{
    public class GetListExamResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
