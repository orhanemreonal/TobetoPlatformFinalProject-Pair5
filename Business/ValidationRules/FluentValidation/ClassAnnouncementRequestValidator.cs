using Business.Dtos.Certificate.Requests;
using Business.Dtos.ClassAnnouncement.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ClassAnnouncementRequestValidator : AbstractValidator<CreateClassAnnouncementRequest>
    {
        public ClassAnnouncementRequestValidator()
        {
        }
    }
}
