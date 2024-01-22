using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Instructor.Requests;
using Business.Dtos.Instructor.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
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

        public async Task<GetInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest)
        {
            Instructor? instructor = await _instructorDal.GetAsync(predicate: i => i.Id == updateInstructorRequest.Id);
            await _instructorBusinessRules.InstructorShouldExistWhenSelected(instructor);

            Instructor? updatedInstructor = _mapper.Map(updateInstructorRequest, instructor);
            await _instructorDal.UpdateAsync(updatedInstructor);

            User? user = await _userDal.GetAsync(predicate: u => u.Id == instructor.UserId);
            await _userBusinessRules.CheckIfUserNotExist(user);

            User? updatedUser = _mapper.Map(updateInstructorRequest, user);
            await _userDal.UpdateAsync(user!);

            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(updatedInstructor);
            return response;

        }
    }
}

//first commit