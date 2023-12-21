﻿namespace Business.Dtos.Student.Responses
{
    public class GetStudentResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClassRoomId { get; set; }
        public Guid? PersonalInformationId { get; set; }
    }
}
