namespace Business.Dtos.Education.Requests
{
    public class CreateEducationRequest
    {
        public Guid StudentId { get; set; }
        public string EducationalStatus { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime? GraduationYear { get; set; }
        public bool IsContinued { get; set; }
    }
}
