namespace Business.Dtos.VirtualClass.Requests
{
    public class UpdateVirtualClassRequest
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
