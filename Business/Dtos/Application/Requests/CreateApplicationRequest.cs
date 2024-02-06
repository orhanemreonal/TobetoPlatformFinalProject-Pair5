namespace Business.Dtos.Application.Requests
{
    public class CreateApplicationRequest
    {
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
    }
}
