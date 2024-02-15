using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Application.Requests;
using Business.Dtos.Application.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Application = Entities.Concretes.Application;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;
        IMapper _mapper;
        ApplicationBusinessRules _businessRules;


        public ApplicationManager(IApplicationDal applicationDal, IMapper mapper, ApplicationBusinessRules businessRules
)
        {
            _applicationDal = applicationDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetApplicationResponse> Add(CreateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);


            await _applicationDal.AddAsync(application);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public async Task<GetApplicationResponse> Delete(DeleteApplicationRequest request)
        {
            Application application = await _applicationDal.GetAsync(predicate: c => c.Id == request.Id);
            await _businessRules.ApplicationShouldExistWhenSelected(application);

            await _applicationDal.DeleteAsync(application);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public async Task<GetApplicationResponse> Get(Guid id)
        {
            Application application = await _applicationDal.GetAsync(predicate: c => c.Id == id);

            await _businessRules.ApplicationShouldExistWhenSelected(application);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public async Task<IPaginate<GetListApplicationResponse>> GetList(PageRequest request)
        {
            var result = await _applicationDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListApplicationResponse> response = _mapper.Map<Paginate<GetListApplicationResponse>>(result);
            return response;
        }
        public async Task<IPaginate<GetListApplicationResponse>> GetListByStudentId(PageRequest request, Guid id)
        {
            var result = await _applicationDal.GetListAsync(index: request.Index, size: request.Size, predicate: a=>a.StudentId==id );
            Paginate<GetListApplicationResponse> response = _mapper.Map<Paginate<GetListApplicationResponse>>(result);
            return response;
        }
        public async Task<GetApplicationResponse> Update(UpdateApplicationRequest request)
        {
            var result = await _applicationDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.ApplicationShouldExistWhenSelected(result);

            await _applicationDal.UpdateAsync(result);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(result);
            return response;
        }
    }
}
