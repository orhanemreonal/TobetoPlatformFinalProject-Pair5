using AutoMapper;
using Business.Abstracts;
using Business.Dtos.CourseTopic.Requests;
using Business.Dtos.CourseTopic.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseTopicManager : ICourseTopicService
    {
        ICourseTopicDal _courseTopicDal;
        IMapper _mapper;

        public CourseTopicManager(ICourseTopicDal courseTopicDal, IMapper mapper)
        {
            _courseTopicDal = courseTopicDal;
            _mapper = mapper;
        }

        public async Task<GetCourseTopicResponse> Add(CreateCourseTopicRequest request)
        {
            CourseTopic courseTopic = _mapper.Map<CourseTopic>(request);
            await _courseTopicDal.AddAsync(courseTopic);
            GetCourseTopicResponse response = _mapper.Map<GetCourseTopicResponse>(courseTopic);
            return response;
        }

        public async Task<GetCourseTopicResponse> Delete(DeleteCourseTopicRequest request)
        {
            CourseTopic courseTopic = await _courseTopicDal.GetAsync(predicate: u => u.Id == request.Id);
            await _courseTopicDal.DeleteAsync(courseTopic);
            GetCourseTopicResponse response = _mapper.Map<GetCourseTopicResponse>(courseTopic);
            return response;
        }

        public async Task<GetCourseTopicResponse> Get(Guid id)
        {
            CourseTopic courseTopic = await _courseTopicDal.GetAsync(predicate: u => u.Id == id);
            GetCourseTopicResponse response = _mapper.Map<GetCourseTopicResponse>(courseTopic);
            return response;
        }

        public async Task<IPaginate<GetListCourseTopicResponse>> GetList(PageRequest request)
        {
            var result = await _courseTopicDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCourseTopicResponse> response = _mapper.Map<Paginate<GetListCourseTopicResponse>>(result);
            return response;
        }

        public async Task<GetCourseTopicResponse> Update(UpdateCourseTopicRequest request)
        {
            CourseTopic updatedCourseTopic = _mapper.Map<CourseTopic>(request);
            await _courseTopicDal.UpdateAsync(updatedCourseTopic);
            GetCourseTopicResponse response = _mapper.Map<GetCourseTopicResponse>(updatedCourseTopic);
            return response;
        }
    }
}
