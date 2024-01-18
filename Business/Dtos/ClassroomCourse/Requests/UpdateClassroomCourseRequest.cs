namespace Business.Dtos.ClassroomCourse.Requests
{
    public class UpdateClassroomCourseRequest
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public Guid CourseId { get; set; }
    }
}
