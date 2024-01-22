namespace Business.Dtos.CourseTopic.Requests
{
    public class CreateCourseTopicRequest
    {
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
    }
}
