using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CourseBusinessRules : BaseBusinessRules
    {
        ICourseDal _courseDal;

        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public Task CourseShouldExistWhenSelected(Course? course)
        {
            if (course == null)
                throw new BusinessException(Messages.CourseNotExists);
            return Task.CompletedTask;
        }

        public async Task CourseIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Course? course = await _courseDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CourseShouldExistWhenSelected(course);
        }
    }
}
