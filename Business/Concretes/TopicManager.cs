﻿using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Topic.Requests;
using Business.Dtos.Topic.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TopicManager : ITopicService
    {
        ITopicDal _topicDal;
        IMapper _mapper;
        TopicBusinessRules _businessRules;

        public TopicManager(ITopicDal topicDal, IMapper mapper, TopicBusinessRules businessRules)
        {
            _topicDal = topicDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetTopicResponse> Add(CreateTopicRequest request)
        {
            Topic topic = _mapper.Map<Topic>(request);

            await _businessRules.CheckIfTopicExist(topic);

            await _topicDal.AddAsync(topic);
            GetTopicResponse response=_mapper.Map<GetTopicResponse>(request);
            return response;
        }

        public async Task<GetTopicResponse> Delete(DeleteTopicRequest request)
        {
            Topic topic = await _topicDal.GetAsync(predicate: t => t.Id == request.Id);

            await _businessRules.CheckIfTopicNotExist(topic);


            await _topicDal.DeleteAsync(topic);
            GetTopicResponse response=_mapper.Map<GetTopicResponse>(topic);
            return response;
        }

        public async Task<GetTopicResponse> Get(Guid id)
        {
            Topic topic = await _topicDal.GetAsync(predicate: t => t.Id == id);

            await _businessRules.CheckIfTopicNotExist(topic);


            GetTopicResponse response = _mapper.Map<GetTopicResponse>(topic);
            return response;
        }

        public async Task<IPaginate<GetListTopicResponse>> GetList(PageRequest request)
        {
            var result = await _topicDal.GetListAsync(index:request.Index,size:request.Size);
            Paginate<GetListTopicResponse> response=_mapper.Map<Paginate<GetListTopicResponse>>(result); 
            return response;
        }

        public async Task<GetTopicResponse> Update(UpdateTopicRequest request)
        {
            Topic topic = _mapper.Map<Topic>(request);

            await _businessRules.CheckIfTopicNotExist(topic);


            await _topicDal.UpdateAsync(topic);
            GetTopicResponse response = _mapper.Map<GetTopicResponse>(request);
            return response;
        }
    }
}