namespace Business.Dtos.Course.Responses
{
    public class GetCourseDetailResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string About { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SpentTime { get; set; }
        public DateTime EstimatedTime { get; set; }
        //public Company? Company { get; set; }
        //public Category? Category { get; set; }
        //public Like? Like { get; set; }
        //public List<ClassroomCourse>? ClassroomCourses { get; set; }
        public List<GetCourseDetailCourseTopicRespnse>? CourseTopics { get; set; }

    }

    public class GetCourseDetailCourseTopicRespnse
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        public Guid CourseId { get; set; }
        public GetCourseDetailTopicResponse? Topic { get; set; }
        //public Course? Course { get; set; }
    }

    public class GetCourseDetailTopicResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public List<AsyncVideo>? AsyncVideos { get; set; }
        //public List<VirtualClass>? VirtualClasses { get; set; }
        //public List<CourseTopic>? CourseTopics { get; set; }

        public List<GetCourseDetailTitleResponse>? Titles { get; set; }
    }

    public class GetCourseDetailTitleResponse
    {
        public Guid Id { get; set; }
        public Guid TopicId { get; set; }
        //public Guid LikeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
        public string Subtype { get; set; }
        public string VideoLanguage { get; set; }
        public string VideoLink { get; set; }
        //public Topic? Topic { get; set; }
        //public Like? Like { get; set; }

    }
}