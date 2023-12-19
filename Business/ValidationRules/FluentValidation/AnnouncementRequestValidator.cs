using Business.Dtos.Announcement.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AnnouncementRequestValidator : AbstractValidator<CreateAnnouncementRequest>
    {
        public AnnouncementRequestValidator()
        {

        }
    }
}
