﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Classroom.Requests;
using Business.Dtos.Classroom.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ClassroomManager : IClassroomService
    {
        IClassroomDal _classroomDal;
        IMapper _mapper;

        public ClassroomManager(IClassroomDal classroomDal, IMapper mapper)
        {
            _classroomDal = classroomDal;
            _mapper = mapper;
        }

        public async Task<GetClassroomResponse> Add(CreateClassroomRequest request)
        {
            Classroom classRoom = _mapper.Map<Classroom>(request);
            await _classroomDal.AddAsync(classRoom);
            //await _personalInformationDal.AddAsync(new PersonalInformation());
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classRoom);
            return response;
        }

        public async Task<GetClassroomResponse> Delete(DeleteClassroomRequest request)
        {
            Classroom classRoom = await _classroomDal.GetAsync(predicate: c => c.Id == request.Id);
            await _classroomDal.DeleteAsync(classRoom);
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classRoom);
            return response;
        }

        public async Task<GetClassroomResponse> Get(Guid id)
        {
            Classroom classRoom = await _classroomDal.GetAsync(predicate: cm => cm.Id == id);
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classRoom);
            return response;
        }

        public async Task<IPaginate<GetListClassroomResponse>> GetList(PageRequest request)
        {
            var result = await _classroomDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListClassroomResponse> response = _mapper.Map<Paginate<GetListClassroomResponse>>(result);
            return response;
        }

        public async Task<GetClassroomResponse> Update(UpdateClassroomRequest request)
        {
            Classroom updatedClassroom = _mapper.Map<Classroom>(request);

            await _classroomDal.UpdateAsync(updatedClassroom);
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(updatedClassroom);
            return response;
        }
    }
}