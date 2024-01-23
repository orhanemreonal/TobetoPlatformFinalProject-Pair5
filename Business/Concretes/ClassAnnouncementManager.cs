using AutoMapper;
using Business.Abstracts;
using Business.Dtos.ClassAnnouncement.Requests;
using Business.Dtos.ClassAnnouncement.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ClassAnnouncementManager : IClassAnnouncementService
    {
        IClassAnnouncementDal _classAnnouncementDal;
        IMapper _mapper;

        public ClassAnnouncementManager(IClassAnnouncementDal classAnnouncementDal, IMapper mapper)
        {
            _classAnnouncementDal = classAnnouncementDal;
            _mapper = mapper;
        }

        public async Task<GetClassAnnouncementResponse> Add(CreateClassAnnouncementRequest request)
        {
            ClassAnnouncement classAnnouncement = _mapper.Map<ClassAnnouncement>(request);
            await _classAnnouncementDal.AddAsync(classAnnouncement);
            GetClassAnnouncementResponse response = _mapper.Map<GetClassAnnouncementResponse>(request);
            return response;
        }

        public async Task<GetClassAnnouncementResponse> Delete(DeleteClassAnnouncementRequest request)
        {
            ClassAnnouncement classAnnouncement = await _classAnnouncementDal.GetAsync(predicate: ca => ca.Id == request.Id);
            await _classAnnouncementDal.DeleteAsync(classAnnouncement);
            GetClassAnnouncementResponse response = _mapper.Map<GetClassAnnouncementResponse>(classAnnouncement);
            return response;


        }

        public async Task<GetClassAnnouncementResponse> Get(Guid id)
        {
            ClassAnnouncement classAnnouncement = await _classAnnouncementDal.GetAsync(predicate: ca => ca.Id == id);
            GetClassAnnouncementResponse response = _mapper.Map<GetClassAnnouncementResponse>(classAnnouncement);
            return response;


        }

        public async Task<IPaginate<GetListClassAnnouncementResponse>> GetList(PageRequest request)
        {
            var result = await _classAnnouncementDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListClassAnnouncementResponse> response = _mapper.Map<Paginate<GetListClassAnnouncementResponse>>(result);
            return response;
        }

        public async Task<GetClassAnnouncementResponse> Update(UpdateClassAnnouncementRequest request)
        {
            var result = await _classAnnouncementDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);

            await _classAnnouncementDal.UpdateAsync(result);
            GetClassAnnouncementResponse response = _mapper.Map<GetClassAnnouncementResponse>(result);
            return response;
        }
    }
}
