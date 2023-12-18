using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Instructor.Requests;
using Business.Dtos.Instructor.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        private readonly IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
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
            Instructor updatedInstructor = _mapper.Map<Instructor>(updateInstructorRequest);
            await _instructorDal.UpdateAsync(updatedInstructor);
            GetInstructorResponse response = _mapper.Map<GetInstructorResponse>(updatedInstructor);
            return response;
        }
    }
}

//first commit