namespace Business.Dtos.Competence.Requests
{
    public class CreateCompetenceRequest
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }

    }
}
