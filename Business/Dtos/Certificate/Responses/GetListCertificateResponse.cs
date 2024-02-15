namespace Business.Dtos.Certificate.Responses
{
    public class GetListCertificateResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
