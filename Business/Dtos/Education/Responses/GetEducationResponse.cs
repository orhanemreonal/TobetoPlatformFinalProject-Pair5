namespace Business.Dtos.Education.Responses
{
    public class GetEducationResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string EducationalStatus { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime? GraduationYear { get; set; }
        public bool IsContinued { get; set; }
    }
}
