using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SocialMediaStudent.Requests;
using Business.Dtos.SocialMediaStudent.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class SocialMediaStudentManager : ISocialMediaStudentService
    {
        ISocialMediaStudentDal _socialMediaStudentDal;
        IMapper _mapper;
        SocialMediaStudentBusinessRules _businessRules;

        public SocialMediaStudentManager(ISocialMediaStudentDal socialMediaStudentDal, IMapper mapper, SocialMediaStudentBusinessRules businessRules)
        {
            _socialMediaStudentDal = socialMediaStudentDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetSocialMediaStudentResponse> Add(CreateSocialMediaStudentRequest createSocialMediaStudentRequest)
        {

            SocialMediaStudent socialMediaStudent = _mapper.Map<SocialMediaStudent>(createSocialMediaStudentRequest);

            await _socialMediaStudentDal.AddAsync(socialMediaStudent);
            GetSocialMediaStudentResponse response = _mapper.Map<GetSocialMediaStudentResponse>(socialMediaStudent);
            return response;
        }

        public async Task<GetSocialMediaStudentResponse> Delete(DeleteSocialMediaStudentRequest deleteSocialMediaStudentRequest)
        {
            SocialMediaStudent socialMediaStudent = await _socialMediaStudentDal.GetAsync(predicate: u => u.Id == deleteSocialMediaStudentRequest.Id);

            await _businessRules.SocialMediaStudentShouldExistWhenSelected(socialMediaStudent);

            await _socialMediaStudentDal.DeleteAsync(socialMediaStudent);
            GetSocialMediaStudentResponse response = _mapper.Map<GetSocialMediaStudentResponse>(socialMediaStudent);
            return response;
        }

        public async Task<GetSocialMediaStudentResponse> Get(Guid id)
        {
            SocialMediaStudent socialMediaStudent = await _socialMediaStudentDal.GetAsync(predicate: u => u.Id == id, include: x => x.Include(y => y.SocialMedia));
            await _businessRules.SocialMediaStudentShouldExistWhenSelected(socialMediaStudent);
            GetSocialMediaStudentResponse response = _mapper.Map<GetSocialMediaStudentResponse>(socialMediaStudent);
            return response;
        }

        public async Task<IPaginate<GetListSocialMediaStudentResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _socialMediaStudentDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size, include: x => x.Include(y => y.SocialMedia));
            Paginate<GetListSocialMediaStudentResponse> response = _mapper.Map<Paginate<GetListSocialMediaStudentResponse>>(result);
            return response;
        }

        public async Task<GetSocialMediaStudentResponse> Update(UpdateSocialMediaStudentRequest request)
        {
            var result = await _socialMediaStudentDal.GetAsync(predicate: a => a.Id == request.Id);
            await _businessRules.SocialMediaStudentShouldExistWhenSelected(result);
            _mapper.Map(request, result);

            await _socialMediaStudentDal.UpdateAsync(result);
            GetSocialMediaStudentResponse response = _mapper.Map<GetSocialMediaStudentResponse>(result);
            return response;

        }

        public async Task<IPaginate<GetListSocialMediaStudentResponse>> GetListByUserId(GetSocialMediaStudentByUserIdRequest request)
        {
            var result = await _socialMediaStudentDal.GetListAsync(
                index: request.Index,
                size: request.Size,
                include: x => x
                    .Include(sl => sl.SocialMedia)
                    .Include(sl => sl.Student),
                predicate: x => x.Student.UserId == request.UserId
                );
            Paginate<GetListSocialMediaStudentResponse> response = _mapper.Map<Paginate<GetListSocialMediaStudentResponse>>(result);
            return response;
        }
        public async Task<IPaginate<GetListSocialMediaStudentResponse>> GetListByStudentId(PageRequest request,Guid id)
        {
            var result = await _socialMediaStudentDal.GetListAsync(
                index: request.Index,
                size: request.Size,
                include: x => x
                    .Include(sl => sl.SocialMedia)
                    .Include(sl => sl.Student),
                predicate: x => x.StudentId == id
                );
            Paginate<GetListSocialMediaStudentResponse> response = _mapper.Map<Paginate<GetListSocialMediaStudentResponse>>(result);
            return response;
        }
    }
}
