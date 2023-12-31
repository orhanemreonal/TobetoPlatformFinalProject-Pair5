﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Experience.Requests;
using Business.Dtos.Experience.Responses;

using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        private readonly IMapper _mapper;

        public ExperienceManager(IExperienceDal experienceDal, IMapper mapper)
        {
            _experienceDal = experienceDal;
            _mapper = mapper;
        }

        public async Task<GetExperienceResponse> Add(CreateExperienceRequest createExperienceRequest)
        {
            Experience experience = _mapper.Map<Experience>(createExperienceRequest);
            await _experienceDal.AddAsync(experience);
            GetExperienceResponse response = _mapper.Map<GetExperienceResponse>(experience);
            return response;
        }

        public async Task<GetExperienceResponse> Delete(DeleteExperienceRequest deleteExperienceRequest)
        {
            Experience experience = await _experienceDal.GetAsync(predicate: l => l.Id == deleteExperienceRequest.Id);
            await _experienceDal.DeleteAsync(experience);
            GetExperienceResponse response = _mapper.Map<GetExperienceResponse>(experience);
            return response;
        }

        public async Task<GetExperienceResponse> Get(Guid id)
        {
            Experience experience = await _experienceDal.GetAsync(predicate: l => l.Id == id);
            GetExperienceResponse response = _mapper.Map<GetExperienceResponse>(experience);
            return response;
        }

        public async Task<IPaginate<GetListExperienceResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _experienceDal.GetListAsync(
                 index: pageRequest.Index,
                 size: pageRequest.Size
                 );
            Paginate<GetListExperienceResponse> response = _mapper.Map<Paginate<GetListExperienceResponse>>(result);
            return response;
        }

        public async Task<GetExperienceResponse> Update(UpdateExperienceRequest updateExperienceRequest)
        {
            Experience updatedExperience = _mapper.Map<Experience>(updateExperienceRequest);
            await _experienceDal.UpdateAsync(updatedExperience);
            GetExperienceResponse response = _mapper.Map<GetExperienceResponse>(updatedExperience);
            return response;
        }
    }
}
