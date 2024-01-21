using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Classroom.Requests;
using Business.Dtos.Classroom.Responses;
using Business.Rules;
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
        ClassroomBusinessRules _businessRules;

        public ClassroomManager(IClassroomDal classroomDal, IMapper mapper, ClassroomBusinessRules businessRules)
        {
            _classroomDal = classroomDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetClassroomResponse> Add(CreateClassroomRequest request)
        {
            Classroom classroom = _mapper.Map<Classroom>(request);

            await _businessRules.CheckIfClassroomExist(classroom);

            await _classroomDal.AddAsync(classroom);
            //await _personalInformationDal.AddAsync(new PersonalInformation());
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classroom);
            return response;
        }

        public async Task<GetClassroomResponse> Delete(DeleteClassroomRequest request)
        {
            Classroom classroom = await _classroomDal.GetAsync(predicate: c => c.Id == request.Id);

            await _businessRules.CheckIfClassroomNotExist(classroom);

            await _classroomDal.DeleteAsync(classroom);
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classroom);
            return response;
        }

        public async Task<GetClassroomResponse> Get(Guid id)
        {
            Classroom classroom = await _classroomDal.GetAsync(predicate: cm => cm.Id == id);

            await _businessRules.CheckIfClassroomNotExist(classroom);

            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(classroom);
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

            await _businessRules.CheckIfClassroomNotExist(updatedClassroom);


            await _classroomDal.UpdateAsync(updatedClassroom);
            GetClassroomResponse response = _mapper.Map<GetClassroomResponse>(updatedClassroom);
            return response;
        }
    }
}