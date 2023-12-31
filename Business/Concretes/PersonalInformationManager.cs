﻿using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.PersonelInformations.Responses;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class PersonalInformationManager : IPersonalInformationService
    {
        IPersonalInformationDal _personalInformationDal;
        IMapper _mapper;
        public PersonalInformationManager(IPersonalInformationDal personalInformationDal, IMapper mapper)
        {

            _personalInformationDal = personalInformationDal;
            _mapper = mapper;

        }
        public async Task<GetPersonalInformationResponse> Add(CreatePersonalInformationRequest createUserRequest)
        {
            PersonalInformation personalInformation = _mapper.Map<PersonalInformation>(createUserRequest);
            await _personalInformationDal.AddAsync(personalInformation);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;
        }

        public async Task<GetPersonalInformationResponse> Delete(DeletePersonalInformationRequest deletePersonalInformationRequest)
        {
            PersonalInformation personalInformation = await _personalInformationDal.GetAsync(predicate: u => u.Id == deletePersonalInformationRequest.Id);
            await _personalInformationDal.DeleteAsync(personalInformation);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;

        }

        public async Task<GetPersonalInformationResponse> Get(Guid id)    
        {
            PersonalInformation personalInformation = await _personalInformationDal.GetAsync(predicate: u => u.Id == id);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(personalInformation);
            return response;
        }

        public async Task<IPaginate<GetListPersonalInformationResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _personalInformationDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
            Paginate<GetListPersonalInformationResponse> response = _mapper.Map<Paginate<GetListPersonalInformationResponse>>(result);
            return response;
        }

        public async Task<GetPersonalInformationResponse> Update(UpdatePersonalInformationRequest updatePersonalInformationRequest)
        {
            PersonalInformation updatedUser = _mapper.Map<PersonalInformation>(updatePersonalInformationRequest);
            await _personalInformationDal.UpdateAsync(updatedUser);
            GetPersonalInformationResponse response = _mapper.Map<GetPersonalInformationResponse>(updatedUser); 
            return response;
        }
    }
}
