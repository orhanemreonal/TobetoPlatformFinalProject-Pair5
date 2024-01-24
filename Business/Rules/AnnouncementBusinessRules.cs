using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class AnnouncementBusinessRules : BaseBusinessRules
    {

        IAnnouncementDal _announcementDal;

        public AnnouncementBusinessRules(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }


        public Task AnnouncementShouldExistWhenSelected(Announcement? announcement)
        {
            if (announcement == null)
                throw new BusinessException(Messages.AnnouncementNotExists);
            return Task.CompletedTask;
        }

        public async Task AnnouncementIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Announcement? announcement = await _announcementDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await AnnouncementShouldExistWhenSelected(announcement);
        }

        //public Task AnnouncementShouldExistWhenSelected(Announcement? announcement)
        //{
        //    if (announcement == null)
        //        throw new BusinessException(Messages.AnnouncementNotExists);
        //    return Task.CompletedTask;
        //}

        //public async Task AnnouncementIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        //{
        //    Announcement? announcement = await _announcementDal.GetAsync(
        //        predicate: at => at.Id == id,
        //        enableTracking: false,
        //        cancellationToken: cancellationToken
        //    );
        //    await AnnouncementShouldExistWhenSelected(announcement);
        //}
    }
}
