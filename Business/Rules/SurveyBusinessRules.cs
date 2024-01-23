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
        public Task CheckIfSurveyNotExist(Survey? survey)
        {
            if (survey == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfSurveyExist(Survey? survey)
        {
            if (survey != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfSurveyNotExist(Guid id)
        {
            Survey survey = _surveyDal.Get(a => a.Id == id);
            CheckIfSurveyNotExist(survey);
        }
    }
}
