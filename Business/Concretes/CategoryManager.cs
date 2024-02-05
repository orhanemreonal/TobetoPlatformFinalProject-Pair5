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
        CategoryBusinessRules _businessRules;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules businessRules)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }
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
            await _businessRules.CategoryShouldExistWhenSelected(category);
            await _categoryDal.DeleteAsync(category);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(category);
            return response;
        }

        public async Task<GetCategoryResponse> Get(Guid id)
        {
            Category category = await _categoryDal.GetAsync(predicate: c => c.Id == id);
            await _businessRules.CategoryShouldExistWhenSelected(category);
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
            var result = await _categoryDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.CategoryShouldExistWhenSelected(result);
            await _categoryDal.UpdateAsync(result);
            GetCategoryResponse response = _mapper.Map<GetCategoryResponse>(result);
            return response;
        }
    }
}
