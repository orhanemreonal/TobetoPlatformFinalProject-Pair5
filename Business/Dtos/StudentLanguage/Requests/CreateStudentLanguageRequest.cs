namespace Business.Dtos.Students.Requests
{
    public class CreateStudentLanguageRequest
    {
        public Guid StudentId { get; set; }

        public Guid LanguageId { get; set; }

        public Guid LanguageLevelId { get; set; }


    }
}
