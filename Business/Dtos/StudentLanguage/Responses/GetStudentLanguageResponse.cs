namespace Business.Dtos.Students.Responses
{
    public class GetStudentLanguageResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid LanguageId { get; set; }

        public string LanguageLevel { get; set; }
        public string Message { get; set; }


    }
}
