using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Language.Requests;
using Business.Dtos.Language.Responses;
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

        public LanguageManager(ILanguageDal languageDal, IMapper mapper)
        {
            _languageDal = languageDal;
            _mapper = mapper;
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

        public async Task<GetLanguageResponse> Update(UpdateLanguageRequest updateLanguageRequest)
        {
            Language updatedLanguage  = _mapper.Map<Language>(updateLanguageRequest);
            await _languageDal.UpdateAsync(updatedLanguage);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(updatedLanguage);
            return response;
        }

        public async Task<GetLanguageResponse> Delete(DeleteLanguageRequest deleteLanguageRequest)
        {
            Language language = await _languageDal.GetAsync(predicate: l => l.Id == deleteLanguageRequest.Id);
            await _languageDal.DeleteAsync(language);
            GetLanguageResponse response = _mapper.Map<GetLanguageResponse>(language);
            return response;
        }
    }
}
