namespace Business.Dtos.Students.Responses
{
    public class GetListStudentLanguageResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid LanguageId { get; set; }
        public string LanguageName { get; set; }

        public Guid LanguageLevelId { get; set; }
        public string LanguageLevel { get; set; }


    }
}
