using AutoMapper;
using Business.Abstracts;
using Business.Dtos.StudentLike.Requests;
using Business.Dtos.StudentLike.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class StudentLikeManager : IStudentLikeService
    {
        IStudentLikeDal _studentLikeDal;
        IMapper _mapper;

        public StudentLikeManager(IStudentLikeDal studentLikeDal, IMapper mapper)
        {
            _studentLikeDal = studentLikeDal;
            _mapper = mapper;
        }

        public async Task<GetStudentLikeResponse> Add(CreateStudentLikeRequest createStudentLikeRequest)
        {
            StudentLike studentLike = _mapper.Map<StudentLike>(createStudentLikeRequest);
            await _studentLikeDal.AddAsync(studentLike);
            GetStudentLikeResponse response = _mapper.Map<GetStudentLikeResponse>(studentLike);
            return response;
        }

        public async Task<GetStudentLikeResponse> Delete(DeleteStudentLikeRequest deleteStudentLikeRequest)
        {
            StudentLike studentLike = await _studentLikeDal.GetAsync(predicate: u => u.Id == deleteStudentLikeRequest.Id);
            await _studentLikeDal.DeleteAsync(studentLike);
            GetStudentLikeResponse response = _mapper.Map<GetStudentLikeResponse>(studentLike);
            return response;
        }

        public async Task<GetStudentLikeResponse> Get(Guid id)
        {
            StudentLike studentlike = await _studentLikeDal.GetAsync(predicate: u => u.Id == id);
            GetStudentLikeResponse response = _mapper.Map<GetStudentLikeResponse>(studentlike);
            return response;
        }

        public async Task<IPaginate<GetListStudentLikeResponse>> GetList(PageRequest request)
        {
            var result = await _studentLikeDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListStudentLikeResponse> response = _mapper.Map<Paginate<GetListStudentLikeResponse>>(result);
            return response;
        }

        public async Task<GetStudentLikeResponse> Update(UpdateStudentLikeRequest updateStudentLikeRequest)
        {
            StudentLike updatedStudentLike = _mapper.Map<StudentLike>(updateStudentLikeRequest);
            await _studentLikeDal.UpdateAsync(updatedStudentLike);
            GetStudentLikeResponse response = _mapper.Map<GetStudentLikeResponse>(updatedStudentLike);
            return response;
        }
    }
}
