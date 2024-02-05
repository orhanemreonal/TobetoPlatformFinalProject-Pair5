namespace Business.Dtos.Students.Requests
{
    public class UpdateStudentLanguageRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }

        public Guid LanguageId { get; set; }

        public Guid LanguageLevelId { get; set; }


    }
}
