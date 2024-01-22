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

        public Task CheckIfCourseNotExist(Course? course)
        {
            if (course == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfCourseExist(Course? course)
        {
            if (course != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfCourseNotExist(Guid id)
        {
            Course course = _courseDal.Get(a => a.Id == id);
            CheckIfCourseNotExist(course);
        }
    }
}
