namespace Business.Dtos.CourseTopic.Responses
{
    public class GetCourseTopicResponse
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
    }
}
