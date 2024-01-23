using AutoMapper;
using Business.Abstracts;
using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.PersonelInformations.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class PersonalInformationManager : IPersonalInformationService
    {
        private readonly IPersonalInformationDal _personalInformationDal;
        private readonly IMapper _mapper;
        private readonly PersonalInformationBusinessRules _personalInformationBusinessRules;


        public PersonalInformationManager(IPersonalInformationDal personalInformationDal, IMapper mapper, PersonalInformationBusinessRules personalInformationBusinessRules)
        {
            _personalInformationDal = personalInformationDal;
            _mapper = mapper;
            _personalInformationBusinessRules = personalInformationBusinessRules;
        }

        public async Task<GetPersonalInformationResponse> Add(CreatePersonalInformationRequest createUserRequest)
        {
            PersonalInformation personalInformation = _mapper.Map<PersonalInformation>(createUserRequest);
            await _personalInformationDal.AddAsync(personalInformation);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;
        }

        public async Task<GetPersonalInformationResponse> Delete(DeletePersonalInformationRequest deletePersonalInformationRequest)
        {
            PersonalInformation personalInformation = await _personalInformationDal.GetAsync(predicate: u => u.Id == deletePersonalInformationRequest.Id);
            await _personalInformationDal.DeleteAsync(personalInformation);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;

        }

        public async Task<GetPersonalInformationResponse> Get(Guid id)
        {
            PersonalInformation personalInformation = await _personalInformationDal.GetAsync(predicate: u => u.Id == id);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;
        }

        public async Task<IPaginate<GetListPersonalInformationResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _personalInformationDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
            Paginate<GetListPersonalInformationResponse> response = _mapper.Map<Paginate<GetListPersonalInformationResponse>>(result);
            return response;
        }

        public async Task<GetPersonalInformationResponse> Update(UpdatePersonalInformationRequest request)
        {
            var result = await _personalInformationDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);

            await _personalInformationDal.UpdateAsync(result);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(result);
            return response;

        }
    }
}
