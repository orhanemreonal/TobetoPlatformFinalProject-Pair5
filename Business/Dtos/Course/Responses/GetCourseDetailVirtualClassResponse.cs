namespace Business.Dtos.Course.Responses
{
    public class GetCourseDetailVirtualClassResponse
    {
        public Guid TopicId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string Name { get; set; }
        public string RecordLink { get; set; }
    }
}