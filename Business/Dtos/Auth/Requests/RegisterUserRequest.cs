using Core.Entities;

namespace Business.Dtos.Auth.Requests
{
    public class RegisterAuthRequest : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}