namespace Business.Dtos.Course.Responses
{
    public class GetCourseDetailTopicResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public List<AsyncVideo>? AsyncVideos { get; set; }
        public List<GetCourseDetailVirtualClassResponse>? VirtualClasses { get; set; }
        //public List<CourseTopic>? CourseTopics { get; set; }

        public List<GetCourseDetailTitleResponse>? Titles { get; set; }
    }
}