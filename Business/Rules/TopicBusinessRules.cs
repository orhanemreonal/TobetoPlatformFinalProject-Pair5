using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class TopicBusinessRules : BaseBusinessRules
    {
        ITopicDal _topicDal;

        public TopicBusinessRules(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }
        public Task TopicShouldExistWhenSelected(Topic? topic)
        {
            if (topic == null)
                throw new BusinessException(Messages.TopicNotExists);
            return Task.CompletedTask;
        }

        public async Task TopicIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Topic? topic = await _topicDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await TopicShouldExistWhenSelected(topic);
        }
    }
}
