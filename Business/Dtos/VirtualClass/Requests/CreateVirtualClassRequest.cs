namespace Business.Dtos.VirtualClass.Requests
{
    public class CreateVirtualClassRequest
    {
        public Guid TopicId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Name { get; set; }
        public string RecordLink { get; set; }
    }
}
