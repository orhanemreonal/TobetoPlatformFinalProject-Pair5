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
        public List<GetCourseDetailCourseTopicResponse>? CourseTopics { get; set; }

    }
}