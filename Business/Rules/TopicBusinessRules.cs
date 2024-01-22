using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class TopicBusinessRules : BaseBusinessRules
    {
        ITopicDal _topicDal;

        public TopicBusinessRules(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }
        public Task CheckIfTopicNotExist(Topic? topic)
        {
            if (topic == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfTopicExist(Topic? topic)
        {
            if (topic != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfTopicNotExist(Guid id)
        {
            Topic topic = _topicDal.Get(a => a.Id == id);
            CheckIfTopicNotExist(topic);
        }
    }
}
