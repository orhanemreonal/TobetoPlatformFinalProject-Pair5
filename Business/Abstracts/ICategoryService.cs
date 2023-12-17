using Business.Dtos.Category.Requests;
using Business.Dtos.Category.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<GetCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
        Task<GetCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest);
        Task<GetCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest);
        Task<IPaginate<GetListCategoryResponse>> GetList(PageRequest pageRequest);
        Task<GetCategoryResponse> Get(Guid id);
    }
}
