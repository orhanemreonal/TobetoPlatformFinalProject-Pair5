using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CourseTopicBusinessRules : BaseBusinessRules
    {
        ICourseTopicDal _courseTopicDal;

        public CourseTopicBusinessRules(ICourseTopicDal courseTopicDal)
        {
            _courseTopicDal = courseTopicDal;
        }

        public Task CourseTopicShouldExistWhenSelected(CourseTopic? courseTopic)
        {
            if (courseTopic == null)
                throw new BusinessException(Messages.CourseTopicNotExists);
            return Task.CompletedTask;
        }

        public async Task CourseTopicIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            CourseTopic? courseTopic = await _courseTopicDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CourseTopicShouldExistWhenSelected(courseTopic);
        }
    }
}
