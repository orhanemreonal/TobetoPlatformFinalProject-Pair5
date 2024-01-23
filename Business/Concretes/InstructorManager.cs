using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Instructor.Requests;
using Business.Dtos.Instructor.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        private readonly InstructorBusinessRules _instructorBusinessRules;
        private readonly UserBusinessRules _userBusinessRules;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper, InstructorBusinessRules instructorBusinessRules, UserBusinessRules userBusinessRules, IUserDal userDal)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
            _instructorBusinessRules = instructorBusinessRules;
            _userBusinessRules = userBusinessRules;
            _userDal = userDal;
        }

        public async Task<GetInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            await _instructorDal.AddAsync(instructor);
            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(instructor);
            return response;
        }

        public async Task<GetInstructorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest)
        {
            Instructor instructor = await _instructorDal.GetAsync(predicate: l => l.Id == deleteInstructorRequest.Id);
            await _instructorBusinessRules.InstructorShouldExistWhenSelected(instructor);
            await _instructorDal.DeleteAsync(instructor);
            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(instructor);
            return response;
        }

        public async Task<GetInstructorResponse> Get(Guid id)
        {
            Instructor instructor = await _instructorDal.GetAsync(predicate: l => l.Id == id);
            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(instructor);
            return response;
        }

        public async Task<IPaginate<GetListInstructorResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _instructorDal.GetListAsync(
                 index: pageRequest.Index,
                 size: pageRequest.Size
                 );
            Paginate<GetListInstructorResponse> response = _mapper.Map<Paginate<GetListInstructorResponse>>(result);
            return response;
        }

        public async Task<GetInstructorResponse> Update(UpdateInstructorRequest request)
        {
            var result = await _instructorDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            // await _userBusinessRules.CheckIfInstructorNotExist(user);

            await _instructorDal.UpdateAsync(result);
            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(result);
            return response;



        }
    }
}

//first commit