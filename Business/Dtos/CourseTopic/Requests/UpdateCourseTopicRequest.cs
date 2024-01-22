namespace Business.Dtos.CourseTopic.Requests
{
    public class UpdateCourseTopicRequest
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
    }
}
