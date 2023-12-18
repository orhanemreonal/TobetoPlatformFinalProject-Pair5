using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Announcement.Requests;
using Business.Dtos.Announcement.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        IMapper _mapper;

        public AnnouncementManager(IAnnouncementDal announcementDal, IMapper mapper)
        {
            _announcementDal = announcementDal;
            _mapper = mapper;
        }

        public async Task<GetAnnouncementResponse> Add(CreateAnnouncementRequest request)
        {
            Announcement announcement = _mapper.Map<Announcement>(request);
            await _announcementDal.AddAsync(announcement);
            GetAnnouncementResponse response = _mapper.Map<GetAnnouncementResponse>(request);
            return response;
        }

        public async Task<GetAnnouncementResponse> Delete(DeleteAnnouncementRequest request)
        {
            Announcement announcement = await _announcementDal.GetAsync(predicate: c => c.Id == request.Id);
            await _announcementDal.DeleteAsync(announcement);
            GetAnnouncementResponse response = _mapper.Map<GetAnnouncementResponse>(announcement);
            return response;
        }

        public async Task<GetAnnouncementResponse> Get(Guid id)
        {
            Announcement announcement = await _announcementDal.GetAsync(predicate: c => c.Id == id);
            GetAnnouncementResponse response = _mapper.Map<GetAnnouncementResponse>(announcement);
            return response;
        }

        public async Task<IPaginate<GetListAnnouncementResponse>> GetList(PageRequest request)
        {
            var result = await _announcementDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListAnnouncementResponse> response = _mapper.Map<Paginate<GetListAnnouncementResponse>>(result);
            return response;
        }

        public async Task<GetAnnouncementResponse> Update(UpdateAnnouncementRequest request)
        {
            Announcement announcement = _mapper.Map<Announcement>(request);
            await _announcementDal.UpdateAsync(announcement);
            GetAnnouncementResponse response = _mapper.Map<GetAnnouncementResponse>(announcement);
            return response;
        }
    }
}
