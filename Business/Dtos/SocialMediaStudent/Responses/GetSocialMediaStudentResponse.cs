namespace Business.Dtos.SocialMediaStudent.Responses
{
    public class GetSocialMediaStudentResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
        public string Url { get; set; }
    }
}
