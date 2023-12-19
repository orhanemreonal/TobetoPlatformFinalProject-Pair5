namespace Business.Dtos.Application.Responses
{
    public class GetApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Destription { get; set; }
        public bool IsAccepted { get; set; }
    }
}
