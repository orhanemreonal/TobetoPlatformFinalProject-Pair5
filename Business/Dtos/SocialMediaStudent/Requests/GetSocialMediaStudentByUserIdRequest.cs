using Core.Business.Requests;

namespace Business.Dtos.SocialMediaStudent.Requests
{
    public class GetSocialMediaStudentByUserIdRequest : PageRequest
    {
        public Guid UserId { get; set; }
    }
}
