using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class ClassAnnouncementBusinessRules : BaseBusinessRules
    {
        IClassAnnouncementDal _classAnnouncementDal;

        public ClassAnnouncementBusinessRules(IClassAnnouncementDal classAnnouncementDal)
        {
            _classAnnouncementDal = classAnnouncementDal;
        }
        public Task ClassAnnouncementShouldExistWhenSelected(ClassAnnouncement? classAnnouncement)
        {
            if (classAnnouncement == null)
                throw new BusinessException(Messages.ClassAnnouncementNotExists);
            return Task.CompletedTask;
        }

        public async Task ClassAnnouncementIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            ClassAnnouncement? classAnnouncement = await _classAnnouncementDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ClassAnnouncementShouldExistWhenSelected(classAnnouncement);
        }
    }
}
