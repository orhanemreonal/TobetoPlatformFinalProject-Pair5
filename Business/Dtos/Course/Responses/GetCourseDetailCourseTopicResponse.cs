namespace Business.Dtos.Course.Responses
{
    public class GetCourseDetailCourseTopicResponse
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
        public GetCourseDetailTopicResponse? Topic { get; set; }
        //public Course? Course { get; set; }
    }
}