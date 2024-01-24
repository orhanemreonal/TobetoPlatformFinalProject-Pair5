using AutoMapper;
using Business.Dtos.Category.Requests;
using Business.Dtos.Category.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            //Requests
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, DeleteCategoryRequest>().ReverseMap();
            CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
            CreateMap<GetCategoryResponse, CreateCategoryRequest>().ReverseMap();
            CreateMap<GetCategoryResponse, DeleteCategoryRequest>().ReverseMap();
            CreateMap<GetCategoryResponse, UpdateCategoryRequest>().ReverseMap();

            //Responses
            CreateMap<Category, GetCategoryResponse>().ReverseMap();
            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();
        }
    }
}
