using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class SurveyBusinessRules : BaseBusinessRules
    {
        ISurveyDal _surveyDal;

        public SurveyBusinessRules(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }
        public Task SurveyShouldExistWhenSelected(Survey? survey)
        {
            if (survey == null)
                throw new BusinessException(Messages.SurveyNotExists);
            return Task.CompletedTask;
        }

        public async Task SurveyIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Survey? survey = await _surveyDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await SurveyShouldExistWhenSelected(survey);
        }
    }
}
