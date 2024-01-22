using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Course.Requests;
using Business.Dtos.Course.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        CourseBusinessRules _businessRules;

        public CourseManager(ICourseDal courseDal, IMapper mapper, CourseBusinessRules businessRules)
        {
            _courseDal = courseDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetCourseResponse> Add(CreateCourseRequest request)
        {
            Course course = _mapper.Map<Course>(request);

            await _businessRules.CheckIfCourseExist(course);

            await _courseDal.AddAsync(course);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;
        }



        public async Task<GetCourseResponse> Delete(DeleteCourseRequest request)
        {
            Course course = await _courseDal.GetAsync(predicate: u => u.Id == request.Id);

            await _businessRules.CheckIfCourseNotExist(course);


            await _courseDal.DeleteAsync(course);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;

        }

        public async Task<GetCourseResponse> Get(Guid id)
        {
            Course course = await _courseDal.GetAsync(predicate: u => u.Id == id);

            await _businessRules.CheckIfCourseNotExist(course);


            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetList(PageRequest request)
        {
            var result = await _courseDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCourseResponse> response = _mapper.Map<Paginate<GetListCourseResponse>>(result);
            return response;
        }

        public async Task<GetCourseResponse> Update(UpdateCourseRequest request)
        {
            Course updatedCourse = _mapper.Map<Course>(request);

            await _businessRules.CheckIfCourseNotExist(updatedCourse);


            await _courseDal.UpdateAsync(updatedCourse);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(updatedCourse);
            return response;
        }
    }
}
