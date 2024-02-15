namespace Business.Dtos.Certificate.Requests
{
    public class UpdateCertificateRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
    }
}
