using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class ClassroomCourseBusinessRules : BaseBusinessRules
    {
        IClassroomCourseDal _classroomCourseDal;

        public ClassroomCourseBusinessRules(IClassroomCourseDal classroomCourseDal)
        {
            _classroomCourseDal = classroomCourseDal;
        }

        public Task ClassroomCourseShouldExistWhenSelected(ClassroomCourse? classroomCourse)
        {
            if (classroomCourse == null)
                throw new BusinessException(Messages.ClassroomCourseNotExists);
            return Task.CompletedTask;
        }

        public async Task ClassroomCourseIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            ClassroomCourse? classroomCourse = await _classroomCourseDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ClassroomCourseShouldExistWhenSelected(classroomCourse);
        }
    }


}
