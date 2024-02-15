using Core.Business.Requests;

namespace Business.Dtos.Certificate.Requests
{
    public class GetListByStudentIdRequest : PageRequest
    {
        public Guid StudentId { get; set; }
    }
}
