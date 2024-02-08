using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Education.Requests;
using Business.Dtos.Education.Responses;
using Business.Dtos.Experience.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;
        IMapper _mapper;
        EducationBusinessRules _businessRules;

        public EducationManager(IEducationDal educationDal, IMapper mapper, EducationBusinessRules businessRules)
        {
            _educationDal = educationDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetEducationResponse> Add(CreateEducationRequest request)
        {
            Education education = _mapper.Map<Education>(request);

            await _educationDal.AddAsync(education);
            GetEducationResponse response = _mapper.Map<GetEducationResponse>(education);
            return response;
        }



        public async Task<GetEducationResponse> Delete(DeleteEducationRequest request)
        {
            Education education = await _educationDal.GetAsync(predicate: u => u.Id == request.Id);

            await _businessRules.EducationShouldExistWhenSelected(education);


            await _educationDal.DeleteAsync(education);
            GetEducationResponse response = _mapper.Map<GetEducationResponse>(education);
            return response;

        }

        public async Task<GetEducationResponse> Get(Guid id)
        {
            Education education = await _educationDal.GetAsync(predicate: u => u.Id == id);

            await _businessRules.EducationShouldExistWhenSelected(education);


            GetEducationResponse response = _mapper.Map<GetEducationResponse>(education);
            return response;
        }

        public async Task<IPaginate<GetListEducationResponse>> GetList(PageRequest request)
        {
            var result = await _educationDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListEducationResponse> response = _mapper.Map<Paginate<GetListEducationResponse>>(result);
            return response;
        }
        public async Task<IPaginate<GetListEducationResponse>> GetListStudentId(PageRequest pageRequest, Guid id)
        {
            var result = await _educationDal.GetListAsync(
                 index: pageRequest.Index,
                 size: pageRequest.Size,
                 predicate: a => a.StudentId == id
                 );
            Paginate<GetListEducationResponse> response = _mapper.Map<Paginate<GetListEducationResponse>>(result);
            return response;
        }
        public async Task<GetEducationResponse> Update(UpdateEducationRequest request)
        {

            var result = await _educationDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.EducationShouldExistWhenSelected(result);
            await _educationDal.UpdateAsync(result);
            GetEducationResponse response = _mapper.Map<GetEducationResponse>(result);
            return response;



        }
    }
}
