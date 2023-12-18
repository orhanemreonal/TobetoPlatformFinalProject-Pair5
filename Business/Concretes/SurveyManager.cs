using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SurveyManager : ISurveyService
    {
        ISurveyDal _surveyDal;
        IMapper _mapper;

        public SurveyManager(ISurveyDal surveyDal, IMapper mapper)
        {
            _surveyDal = surveyDal;
            _mapper = mapper;
        }

        public async Task<GetSurveyResponse> Add(CreateSurveyRequest request)
        {
            Survey survey = _mapper.Map<Survey>(request);
            await _surveyDal.AddAsync(survey);
            GetSurveyResponse response = _mapper.Map<GetSurveyResponse>(request);
            return response;
        }

        public async Task<GetSurveyResponse> Delete(DeleteSurveyRequest request)
        {
            Survey survey = await _surveyDal.GetAsync(predicate: c => c.Id == request.Id);
            await _surveyDal.DeleteAsync(survey);
            GetSurveyResponse response = _mapper.Map<GetSurveyResponse>(survey);
            return response;
        }

        public async Task<GetSurveyResponse> Get(Guid id)
        {
            Survey survey = await _surveyDal.GetAsync(predicate: c => c.Id == id);
            GetSurveyResponse response = _mapper.Map<GetSurveyResponse>(survey);
            return response;
        }

        public async Task<IPaginate<GetListSurveyResponse>> GetList(PageRequest request)
        {
            var result = await _surveyDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListSurveyResponse> response = _mapper.Map<Paginate<GetListSurveyResponse>>(result);
            return response;
        }

        public async Task<GetSurveyResponse> Update(UpdateSurveyRequest request)
        {
            Survey survey = _mapper.Map<Survey>(request);
            await _surveyDal.UpdateAsync(survey);
            GetSurveyResponse response = _mapper.Map<GetSurveyResponse>(survey);
            return response;
        }
    }
}
