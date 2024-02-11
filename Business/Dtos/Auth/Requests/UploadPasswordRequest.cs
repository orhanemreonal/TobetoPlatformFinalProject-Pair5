namespace Business.Dtos.Auth.Requests
{
    public class UploadPasswordRequest
    {
        public Guid UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordAgain { get; set; }

    }
}
