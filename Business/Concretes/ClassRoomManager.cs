using AutoMapper;
using Business.Abstracts;
using Business.Dtos.ClassRoom.Requests;
using Business.Dtos.ClassRoom.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ClassRoomManager : IClassRoomService
    {
        IClassRoomDal _classRoomDal;
        IMapper _mapper;

        public ClassRoomManager(IClassRoomDal classRoomDal, IMapper mapper)
        {
            _classRoomDal = classRoomDal;
            _mapper = mapper;
        }

        public async Task<GetClassRoomResponse> Add(CreateClassRoomRequest request)
        {
            ClassRoom classRoom = _mapper.Map<ClassRoom>(request);
            await _classRoomDal.AddAsync(classRoom);
            //await _personalInformationDal.AddAsync(new PersonalInformation());
            GetClassRoomResponse response = _mapper.Map<GetClassRoomResponse>(classRoom);
            return response;
        }

        public async Task<GetClassRoomResponse> Delete(DeleteClassRoomRequest request)
        {
            ClassRoom classRoom = await _classRoomDal.GetAsync(predicate: c => c.Id == request.Id);
            await _classRoomDal.DeleteAsync(classRoom);
            GetClassRoomResponse response = _mapper.Map<GetClassRoomResponse>(classRoom);
            return response;
        }

        public async Task<GetClassRoomResponse> Get(Guid id)
        {
            ClassRoom classRoom = await _classRoomDal.GetAsync(predicate: cm => cm.Id == id);
            GetClassRoomResponse response = _mapper.Map<GetClassRoomResponse>(classRoom);
            return response;
        }

        public async Task<IPaginate<GetListClassRoomResponse>> GetList(PageRequest request)
        {
            var result = await _classRoomDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListClassRoomResponse> response = _mapper.Map<Paginate<GetListClassRoomResponse>>(result);
            return response;
        }

        public async Task<GetClassRoomResponse> Update(UpdateClassRoomRequest request)
        {
            ClassRoom updatedClassRoom = _mapper.Map<ClassRoom>(request);

            await _classRoomDal.UpdateAsync(updatedClassRoom);
            GetClassRoomResponse response = _mapper.Map<GetClassRoomResponse>(updatedClassRoom);
            return response;
        }
    }
}