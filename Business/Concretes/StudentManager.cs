using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Student.Requests;
using Business.Dtos.Student.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        IMapper _mapper;
        StudentBusinessRules _studentBusinessRules;
        IUserDal _userDal;
        UserBusinessRules _userBusinessRules;

        public StudentManager(IStudentDal studentDal, IMapper mapper, StudentBusinessRules studentBusinessRules, IUserDal userDal, UserBusinessRules userBusinessRules)
        {
            _studentDal = studentDal;
            _mapper = mapper;
            _studentBusinessRules = studentBusinessRules;
            _userDal = userDal;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<GetStudentResponse> Add(CreateStudentRequest request)
        {
            Student student = _mapper.Map<Student>(request);
            await _studentDal.AddAsync(student);
            GetStudentResponse response = _mapper.Map<GetStudentResponse>(request);
            return response;
        }

        public async Task<GetStudentResponse> Delete(DeleteStudentRequest request)
        {
            Student student = await _studentDal.GetAsync(predicate: c => c.Id == request.Id);

            await _studentBusinessRules.StudentShouldExistWhenSelected(student);

            await _studentDal.DeleteAsync(student);

            GetStudentResponse response = _mapper.Map<GetStudentResponse>(student);
            return response;
        }

        public async Task<GetStudentResponse> Get(Guid id)
        {
            Student student = await _studentDal.GetAsync(predicate: c => c.Id == id);
            GetStudentResponse response = _mapper.Map<GetStudentResponse>(student);
            return response;
        }

        public async Task<IPaginate<GetListStudentResponse>> GetList(PageRequest request)
        {
            var result = await _studentDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListStudentResponse> response = _mapper.Map<Paginate<GetListStudentResponse>>(result);
            return response;
        }

        public async Task<GetStudentResponse> Update(UpdateStudentRequest request)
        {
            var result = await _studentDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);

            await _studentDal.UpdateAsync(result);
            GetStudentResponse response = _mapper.Map<GetStudentResponse>(result);
            return response;

        }
    }
}
