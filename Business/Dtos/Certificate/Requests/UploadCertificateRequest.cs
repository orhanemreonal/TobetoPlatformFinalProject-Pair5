using Microsoft.AspNetCore.Http;

namespace Business.Dtos.Certificate.Requests
{
    public class UploadCertificateRequest
    {
        public Guid StudentId { get; set; }
        public IFormFile File { get; set; }
    }
}
