using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.ClassAnnouncement.Requests;
using Business.Dtos.ClassAnnouncement.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ClassAnnouncement classAnnouncement=_mapper.Map<ClassAnnouncement>(request);
            await _classAnnouncementDal.AddAsync(classAnnouncement);
            GetClassAnnouncementResponse response=_mapper.Map<GetClassAnnouncementResponse>(request);
            return response;
        }

        public async Task<GetClassAnnouncementResponse> Delete(DeleteClassAnnouncementRequest request)
        {
            ClassAnnouncement classAnnouncement = await _classAnnouncementDal.GetAsync(predicate:ca=>ca.Id==request.Id);
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

        public async Task<IPaginate<GetClassAnnouncementResponse>> GetList(PageRequest request)
        {
            var result = await _classAnnouncementDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetClassAnnouncementResponse> response=_mapper.Map<Paginate<GetClassAnnouncementResponse>>(result);
            return response;
        }

        public async Task<GetClassAnnouncementResponse> Update(UpdateClassAnnouncementRequest request)
        {
            ClassAnnouncement classAnnouncement=_mapper.Map<ClassAnnouncement>(request);
            await _classAnnouncementDal.UpdateAsync(classAnnouncement);
            GetClassAnnouncementResponse response = _mapper.Map<GetClassAnnouncementResponse>(classAnnouncement);
            return response;
        }
    }
}
