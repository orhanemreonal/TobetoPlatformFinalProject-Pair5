namespace Business.Dtos.Student.Requests
{
    public class CreateStudentRequest
    {
        public Guid UserId { get; set; }
        public Guid ClassRoomId { get; set; }
        public Guid? PersonalInformationId { get; set; }

    }
}
