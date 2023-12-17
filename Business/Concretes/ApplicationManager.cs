using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Application.Requests;
using Business.Dtos.Application.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;
        IMapper _mapper;

        public ApplicationManager(IApplicationDal applicationDal, IMapper mapper)
        {
            _applicationDal = applicationDal;
            _mapper = mapper;
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
            await _applicationDal.DeleteAsync(application);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public async Task<GetApplicationResponse> Get(Guid id)
        {
            Application application = await _applicationDal.GetAsync(predicate: c => c.Id == id);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public async Task<IPaginate<GetListApplicationResponse>> GetList(PageRequest request)
        {
            var result = await _applicationDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListApplicationResponse> response = _mapper.Map<Paginate<GetListApplicationResponse>>(result);
            return response;
        }

        public async Task<GetApplicationResponse> Update(UpdateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            await _applicationDal.UpdateAsync(application);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }
    }
}
