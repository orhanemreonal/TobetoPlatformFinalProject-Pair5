using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Category.Requests;
using Business.Dtos.Category.Responses;
using Business.Rules;
using Core.Aspects.Caching;
using Core.Aspects.Logging;
using Core.Aspects.Performance;
using Core.Business.Requests;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;
        CategoryBusinessRules _categoryBusinessRules;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _categoryBusinessRules = categoryBusinessRules;
        }
        [CacheRemoveAspect("ICategoryService.Get")]
        [LogAspect(typeof(FileLogger))]
        public async Task<GetCategoryResponse> Add(CreateCategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            await _categoryDal.AddAsync(category);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(category);
            return response;
        }
        [CacheRemoveAspect("ICategoryService.Get")]
        public async Task<GetCategoryResponse> Delete(DeleteCategoryRequest request)
        {
            Category category = await _categoryDal.GetAsync(predicate: c => c.Id == request.Id);
            await _categoryBusinessRules.CheckIfCategoryExist(category);

            await _categoryDal.DeleteAsync(category);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(category);
            return response;
        }

        public async Task<GetCategoryResponse> Get(Guid id)
        {
            Category category = await _categoryDal.GetAsync(predicate: c => c.Id == id);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(category);
            return response;
        }
        [CacheAspect]
        [PerformanceAspect(1)]
        [LogAspect(typeof(FileLogger))]
        public async Task<IPaginate<GetListCategoryResponse>> GetList(PageRequest request)
        {
            var result = await _categoryDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCategoryResponse> response = _mapper.Map<Paginate<GetListCategoryResponse>>(result);
            return response;
        }
        [CacheRemoveAspect("ICategoryService.Get")]
        public async Task<GetCategoryResponse> Update(UpdateCategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            await _categoryDal.UpdateAsync(category);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(category);
            return response;
        }
    }
}
