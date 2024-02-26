using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Course.Requests;
using Business.Dtos.Course.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

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

            await _courseDal.AddAsync(course);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;
        }



        public async Task<GetCourseResponse> Delete(DeleteCourseRequest request)
        {
            Course course = await _courseDal.GetAsync(predicate: u => u.Id == request.Id);

            await _businessRules.CourseShouldExistWhenSelected(course);

            await _courseDal.DeleteAsync(course);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;

        }

        public async Task<GetCourseResponse> Get(Guid id)
        {
            Course course = await _courseDal.GetAsync(predicate: u => u.Id == id, include: x => x
                    .Include(c => c.Category)
                    .Include(c => c.Company));

            await _businessRules.CourseShouldExistWhenSelected(course);


            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return response;
        }

        public async Task<GetCourseDetailResponse> GetDetail(Guid id)
        {
            var result = await _courseDal.GetAsync(
                predicate: x => x.Id == id,
                include: x => x.Include(y => y.CourseTopics).ThenInclude(z => z.Topic).ThenInclude(ti => ti.Titles)
                              .Include(y => y.CourseTopics).ThenInclude(z => z.Topic).ThenInclude(vc => vc.VirtualClasses)
                );
            GetCourseDetailResponse response = _mapper.Map<GetCourseDetailResponse>(result);
            return response;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetList(PageRequest request)
        {
            var result = await _courseDal.GetListAsync(index: request.Index, size: request.Size,
                include: x => x
                    .Include(c => c.ClassroomCourses).ThenInclude(c => c.Classroom)
                    .Include(c => c.Category)
                    .Include(c => c.Company));

            result.Items = result.Items = result.Items.Where(x =>
                    x.ClassroomCourses.All(cc => cc.Classroom.Name != "public") ||
                    !x.ClassroomCourses.Any()
                    ).ToList();

            Paginate<GetListCourseResponse> response = _mapper.Map<Paginate<GetListCourseResponse>>(result);
            return response;
        }

        public async Task<IPaginate<GetListCourseResponse>> GetPublicCourseList(PageRequest request)
        {
            var result = await _courseDal.GetListAsync(include: x =>
                x.Include(c => c.ClassroomCourses).ThenInclude(c => c.Classroom)
                .Include(c => c.Category)
                    .Include(c => c.Company)
            );
            result.Items = result.Items.Where(x => x.ClassroomCourses.Any(x => x.Classroom.Name == "public")).ToList();
            Paginate<GetListCourseResponse> response = _mapper.Map<Paginate<GetListCourseResponse>>(result);
            return response;
        }

        public async Task<GetCourseResponse> Update(UpdateCourseRequest request)
        {
            var result = await _courseDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.CourseShouldExistWhenSelected(result);
            await _courseDal.UpdateAsync(result);
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(result);
            return response;




        }
    }
}
