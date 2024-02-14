namespace Business.Dtos.Auth.Requests
{
    public class UploadPasswordRequest
    {
        public Guid UserId { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ReNewPassword { get; set; }

    }
}
