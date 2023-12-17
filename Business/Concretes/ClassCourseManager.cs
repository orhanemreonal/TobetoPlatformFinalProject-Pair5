using AutoMapper;
using Business.Abstracts;
using Business.Dtos.ClassCourse.Requests;
using Business.Dtos.ClassCourse.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ClassCourseManager : IClassCourseService
    {
        IClassCourseDal _classCourseDal;
        IMapper _mapper;

        public ClassCourseManager(IClassCourseDal classCourseDal, IMapper mapper)
        {
            _classCourseDal = classCourseDal;
            _mapper = mapper;
        }

        public async Task<GetClassCourseResponse> Add(CreateClassCourseRequest request)
        {
            ClassCourse classCourse = _mapper.Map<ClassCourse>(request);
            await _classCourseDal.AddAsync(classCourse);
            GetClassCourseResponse response = _mapper.Map<GetClassCourseResponse>(request);
            return response;
        }

        public async Task<GetClassCourseResponse> Delete(DeleteClassCourseRequest request)
        {
            ClassCourse classCourse = await _classCourseDal.GetAsync(predicate: cc => cc.Id == request.Id);
            await _classCourseDal.DeleteAsync(classCourse);
            GetClassCourseResponse response = _mapper.Map<GetClassCourseResponse>(classCourse);
            return response;
        }

        public async Task<GetClassCourseResponse> Get(Guid id)
        {
            ClassCourse classCourse = await _classCourseDal.GetAsync(predicate: cc => cc.Id == id);
            GetClassCourseResponse response = _mapper.Map<GetClassCourseResponse>(classCourse);
            return response;
        }

        public async Task<IPaginate<GetListClassCourseResponse>> GetList(PageRequest request)
        {
            var result = await _classCourseDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListClassCourseResponse> response = _mapper.Map<Paginate<GetListClassCourseResponse>>(result);
            return response;

        }

        public async Task<GetClassCourseResponse> Update(UpdateClassCourseRequest request)
        {
            ClassCourse classCourse = _mapper.Map<ClassCourse>(request);
            await _classCourseDal.UpdateAsync(classCourse);
            GetClassCourseResponse response = _mapper.Map<GetClassCourseResponse>(classCourse);
            return response;
        }
    }
}
