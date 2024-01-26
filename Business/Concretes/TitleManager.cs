using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Title.Requests;
using Business.Dtos.Title.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;
        IMapper _mapper;
        TitleBusinessRules _businessRules;

        public TitleManager(ITitleDal titleDal, IMapper mapper, TitleBusinessRules businessRules)
        {
            _titleDal = titleDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetTitleResponse> Add(CreateTitleRequest request)
        {
            Title title = _mapper.Map<Title>(request);



            await _titleDal.AddAsync(title);
            GetTitleResponse response = _mapper.Map<GetTitleResponse>(request);
            return response;
        }

        public async Task<GetTitleResponse> Delete(DeleteTitleRequest request)
        {
            Title title = await _titleDal.GetAsync(predicate: t => t.Id == request.Id);

            await _businessRules.TitleShouldExistWhenSelected(title);


            await _titleDal.DeleteAsync(title);
            GetTitleResponse response = _mapper.Map<GetTitleResponse>(request);
            return response;
        }

        public async Task<GetTitleResponse> Get(Guid id)
        {
            Title title = await _titleDal.GetAsync(predicate: t => t.Id == id);

            await _businessRules.TitleShouldExistWhenSelected(title);


            GetTitleResponse response = _mapper.Map<GetTitleResponse>(title);
            return response;
        }

        public async Task<IPaginate<GetListTitleResponse>> GetList(PageRequest request)
        {
            var result = await _titleDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListTitleResponse> response = _mapper.Map<Paginate<GetListTitleResponse>>(result);
            return response;
        }

        public async Task<GetTitleResponse> Update(UpdateTitleRequest request)
        {
            var result = await _titleDal.GetAsync(predicate: a => a.Id == request.Id);

            await _businessRules.TitleShouldExistWhenSelected(result);
            _mapper.Map(request, result);

            await _titleDal.UpdateAsync(result);
            GetTitleResponse response = _mapper.Map<GetTitleResponse>(result);
            return response;

        }
    }
}
