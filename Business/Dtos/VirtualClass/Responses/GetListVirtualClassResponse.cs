namespace Business.Dtos.VirtualClass.Responses
{
    public class GetListVirtualClassResponse
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
