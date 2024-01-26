using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Language.Requests;
using Business.Dtos.Language.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageDal _languageDal;
        private readonly IMapper _mapper;
        private readonly LanguageBusinessRules _businessRules;

        public LanguageManager(ILanguageDal languageDal, IMapper mapper, LanguageBusinessRules businessRules)
        {
            _languageDal = languageDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetLanguageResponse> Add(CreateLanguageRequest createLanguageRequest)
        {
            Language language = _mapper.Map<Language>(createLanguageRequest);
            await _languageDal.AddAsync(language);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(language);
            return response;
        }

        public async Task<GetLanguageResponse> Get(Guid id)
        {
            Language language = await _languageDal.GetAsync(predicate: l => l.Id == id);
            await _businessRules.LanguageShouldExistWhenSelected(language);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(language);
            return response;
        }

        public async Task<IPaginate<GetListLanguageResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _languageDal.GetListAsync(
                index: pageRequest.Index,
                size: pageRequest.Size
                );
            Paginate<GetListLanguageResponse> response = _mapper.Map<Paginate<GetListLanguageResponse>>(result);
            return response;
        }

        public async Task<GetLanguageResponse> Update(UpdateLanguageRequest request)
        {
            var result = await _languageDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.LanguageShouldExistWhenSelected(result);
            await _languageDal.UpdateAsync(result);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(result);
            return response;

        }

        public async Task<GetLanguageResponse> Delete(DeleteLanguageRequest deleteLanguageRequest)
        {
            Language language = await _languageDal.GetAsync(predicate: l => l.Id == deleteLanguageRequest.Id);
            await _businessRules.LanguageShouldExistWhenSelected(language);
            await _languageDal.DeleteAsync(language!);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(language);
            return response;
        }
    }
}
