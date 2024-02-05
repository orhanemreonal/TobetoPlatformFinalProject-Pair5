using Core.Business.Requests;

namespace Business.Dtos.StudentLanguage.Requests
{
    public class GetStudentLanguagesByStudentRequest : PageRequest
    {
        public Guid StudentId { get; set; }
    }
}
