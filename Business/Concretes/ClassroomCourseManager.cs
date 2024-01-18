using AutoMapper;
using Business.Abstracts;
using Business.Dtos.ClassroomCourse.Requests;
using Business.Dtos.ClassroomCourse.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ClassroomCourseManager : IClassroomCourseService
    {
        IClassroomCourseDal _classroomCourseDal;
        IMapper _mapper;

        public ClassroomCourseManager(IClassroomCourseDal classroomCourseDal, IMapper mapper)
        {
            _classroomCourseDal = classroomCourseDal;
            _mapper = mapper;
        }

        public async Task<GetClassroomCourseResponse> Add(CreateClassroomCourseRequest request)
        {
            ClassroomCourse classroomCourse = _mapper.Map<ClassroomCourse>(request);
            await _classroomCourseDal.AddAsync(classroomCourse);
            GetClassroomCourseResponse response = _mapper.Map<GetClassroomCourseResponse>(request);
            return response;
        }

        public async Task<GetClassroomCourseResponse> Delete(DeleteClassroomCourseRequest request)
        {
            ClassroomCourse classroomCourse = await _classroomCourseDal.GetAsync(predicate: cc => cc.Id == request.Id);
            await _classroomCourseDal.DeleteAsync(classroomCourse);
            GetClassroomCourseResponse response = _mapper.Map<GetClassroomCourseResponse>(classroomCourse);
            return response;
        }

        public async Task<GetClassroomCourseResponse> Get(Guid id)
        {
            ClassroomCourse classroomCourse = await _classroomCourseDal.GetAsync(predicate: cc => cc.Id == id);
            GetClassroomCourseResponse response = _mapper.Map<GetClassroomCourseResponse>(classroomCourse);
            return response;
        }

        public async Task<IPaginate<GetListClassroomCourseResponse>> GetList(PageRequest request)
        {
            var result = await _classroomCourseDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListClassroomCourseResponse> response = _mapper.Map<Paginate<GetListClassroomCourseResponse>>(result);
            return response;

        }

        public async Task<GetClassroomCourseResponse> Update(UpdateClassroomCourseRequest request)
        {
            ClassroomCourse classroomCourse = _mapper.Map<ClassroomCourse>(request);
            await _classroomCourseDal.UpdateAsync(classroomCourse);
            GetClassroomCourseResponse response = _mapper.Map<GetClassroomCourseResponse>(classroomCourse);
            return response;
        }
    }
}
