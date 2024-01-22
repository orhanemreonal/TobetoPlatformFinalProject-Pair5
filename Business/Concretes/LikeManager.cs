using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Like.Requests;
using Business.Dtos.Like.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class LikeManager : ILikeService
    {
        ILikeDal _likeDal;
        IMapper _mapper;

        public LikeManager(ILikeDal likeDal, IMapper mapper)
        {
            _likeDal = likeDal;
            _mapper = mapper;
        }

        public async Task<GetLikeResponse> Add(CreateLikeRequest request)
        {
            Like like = _mapper.Map<Like>(request);
            await _likeDal.AddAsync(like);
            GetLikeResponse response = _mapper.Map<GetLikeResponse>(like);
            return response;
        }

        public async Task<GetLikeResponse> Delete(DeleteLikeRequest request)
        {
            Like like = await _likeDal.GetAsync(predicate: u => u.Id == request.Id);
            await _likeDal.DeleteAsync(like);
            GetLikeResponse response = _mapper.Map<GetLikeResponse>(like);
            return response;
        }

        public async Task<GetLikeResponse> Get(Guid id)
        {
            Like like = await _likeDal.GetAsync(predicate: u => u.Id == id);
            GetLikeResponse response = _mapper.Map<GetLikeResponse>(like);
            return response;
        }

        public async Task<IPaginate<GetListLikeResponse>> GetList(PageRequest request)
        {
            var result = await _likeDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListLikeResponse> response = _mapper.Map<Paginate<GetListLikeResponse>>(result);
            return response;
        }

        public async Task<GetLikeResponse> Update(UpdateLikeRequest request)
        {
            Like updatedLike = _mapper.Map<Like>(request);
            await _likeDal.UpdateAsync(updatedLike);
            GetLikeResponse response = _mapper.Map<GetLikeResponse>(updatedLike);
            return response;
        }
    }
}
