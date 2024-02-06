namespace Business.Dtos.Application.Requests
{
    public class UpdateApplicationRequest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAccepted { get; set; }
    }
}
