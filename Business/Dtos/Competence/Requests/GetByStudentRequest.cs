using Core.Business.Requests;

namespace Business.Dtos.Competence.Requests
{
    public class GetListByStudentRequest : PageRequest
    {
        public Guid StudentId { get; set; }
    }
}
