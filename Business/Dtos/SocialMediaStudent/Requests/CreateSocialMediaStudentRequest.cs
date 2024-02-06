namespace Business.Dtos.SocialMediaStudent.Requests
{
    public class CreateSocialMediaStudentRequest
    {
        public Guid StudentId { get; set; }

        public Guid SocialMediaId { get; set; }

        public string Url { get; set; }
    }
}
