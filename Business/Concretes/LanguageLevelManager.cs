using AutoMapper;
using Business.Abstracts;
using Business.Dtos.LanguageLevel.Requests;
using Business.Dtos.LanguageLevel.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class LanguageLevelManager : ILanguageLevelService
    {
        private readonly ILanguageLevelDal _languageLevelDal;
        private readonly IMapper _mapper;
        private readonly LanguageLevelBusinessRules _businessRules;

        public LanguageLevelManager(ILanguageLevelDal languageLevelDal, IMapper mapper, LanguageLevelBusinessRules businessRules)
        {
            _languageLevelDal = languageLevelDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetLanguageLevelResponse> Add(CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            LanguageLevel languageLevel = _mapper.Map<LanguageLevel>(createLanguageLevelRequest);
            await _languageLevelDal.AddAsync(languageLevel);
            GetLanguageLevelResponse response = _mapper.Map<GetLanguageLevelResponse>(languageLevel);
            return response;
        }

        public async Task<GetLanguageLevelResponse> Get(Guid id)
        {
            LanguageLevel languageLevel = await _languageLevelDal.GetAsync(predicate: l => l.Id == id);
            await _businessRules.LanguageLevelShouldExistWhenSelected(languageLevel);
            GetLanguageLevelResponse response = _mapper.Map<GetLanguageLevelResponse>(languageLevel);
            return response;
        }

        public async Task<IPaginate<GetListLanguageLevelResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _languageLevelDal.GetListAsync(
                index: pageRequest.Index,
                size: pageRequest.Size
                );
            Paginate<GetListLanguageLevelResponse> response = _mapper.Map<Paginate<GetListLanguageLevelResponse>>(result);
            return response;
        }

        public async Task<GetLanguageLevelResponse> Update(UpdateLanguageLevelRequest request)
        {
            var result = await _languageLevelDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.LanguageLevelShouldExistWhenSelected(result);
            await _languageLevelDal.UpdateAsync(result);
            GetLanguageLevelResponse response = _mapper.Map<GetLanguageLevelResponse>(result);
            return response;

        }

        public async Task<GetLanguageLevelResponse> Delete(DeleteLanguageLevelRequest deleteLanguageLevelRequest)
        {
            LanguageLevel languageLevel = await _languageLevelDal.GetAsync(predicate: l => l.Id == deleteLanguageLevelRequest.Id);
            await _businessRules.LanguageLevelShouldExistWhenSelected(languageLevel);
            await _languageLevelDal.DeleteAsync(languageLevel!);
            GetLanguageLevelResponse response = _mapper.Map<GetLanguageLevelResponse>(languageLevel);
            return response;
        }
    }
}
