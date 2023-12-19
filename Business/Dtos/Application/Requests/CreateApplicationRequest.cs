namespace Business.Dtos.Application.Requests
{
    public class CreateApplicationRequest
    {
        public Guid StudentId { get; set; }
        public string Destription { get; set; }
        public bool IsAccepted { get; set; }

    }
}
