using AutoMapper;
using Business.Abstracts;
using Business.Dtos.AsyncVideo.Requests;
using Business.Dtos.AsyncVideo.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AsyncVideoManager : IAsyncVideoService
    {
        IAsyncVideoDal _asyncVideoDal;
        IMapper _mapper;
        AsyncVideoBusinessRules _asyncVideoBusinessRules;
        public AsyncVideoManager(IAsyncVideoDal asyncVideoDal, IMapper mapper, AsyncVideoBusinessRules asyncVideoBusinessRules)
        {
            _asyncVideoDal = asyncVideoDal;
            _mapper = mapper;
            _asyncVideoBusinessRules = asyncVideoBusinessRules;
        }

        public async Task<GetAsyncVideoResponse> Add(CreateAsyncVideoRequest request)
        {
            AsyncVideo asyncVideo = _mapper.Map<AsyncVideo>(request);
            await _asyncVideoDal.AddAsync(asyncVideo);
            GetAsyncVideoResponse response = _mapper.Map<GetAsyncVideoResponse>(asyncVideo);
            return response;
        }

        public async Task<GetAsyncVideoResponse> Delete(DeleteAsyncVideoRequest request)
        {
            AsyncVideo asyncVideo = await _asyncVideoDal.GetAsync(predicate: u => u.Id == request.Id);
            await _asyncVideoBusinessRules.AsyncVideoShouldExistWhenSelected(asyncVideo);

            await _asyncVideoDal.DeleteAsync(asyncVideo);
            GetAsyncVideoResponse response = _mapper.Map<GetAsyncVideoResponse>(asyncVideo);
            return response;
        }
        public async Task<GetAsyncVideoResponse> Get(Guid id)
        {

            AsyncVideo asyncVideo = await _asyncVideoDal.GetAsync(predicate: u => u.Id == id);
            GetAsyncVideoResponse response = _mapper.Map<GetAsyncVideoResponse>(asyncVideo);
            return response;
        }

        public async Task<IPaginate<GetListAsyncVideoResponse>> GetList(PageRequest request)
        {
            var result = await _asyncVideoDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListAsyncVideoResponse> response = _mapper.Map<Paginate<GetListAsyncVideoResponse>>(result);
            return response;
        }

        public async Task<GetAsyncVideoResponse> Update(UpdateAsyncVideoRequest request)
        {
            var result = await _asyncVideoDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);

            await _asyncVideoDal.UpdateAsync(result);
            GetAsyncVideoResponse response = _mapper.Map<GetAsyncVideoResponse>(result);
            return response;
        }
    }
}
