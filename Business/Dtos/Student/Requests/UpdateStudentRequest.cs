namespace Business.Dtos.Student.Requests
{
    public class UpdateStudentRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClassRoomId { get; set; }
        public Guid? PersonalInformationId { get; set; }
    }
}
