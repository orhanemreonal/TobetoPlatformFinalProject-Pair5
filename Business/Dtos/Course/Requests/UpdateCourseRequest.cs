namespace Business.Dtos.Course.Requests
{
    public class UpdateCourseRequest
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public string About { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime SpentTime { get; set; }
        public DateTime EstimatedTime { get; set; }
    }
}
