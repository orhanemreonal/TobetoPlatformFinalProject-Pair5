using AutoMapper;
using Business.Dtos.Like.Requests;
using Business.Dtos.Like.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class LikeMappingProfile : Profile
    {
        public LikeMappingProfile()
        {
            //Requests
            CreateMap<Like, CreateLikeRequest>().ReverseMap();
            CreateMap<Like, DeleteLikeRequest>().ReverseMap();
            CreateMap<Like, UpdateLikeRequest>().ReverseMap();

            CreateMap<GetLikeResponse, CreateLikeRequest>().ReverseMap();
            CreateMap<GetLikeResponse, DeleteLikeRequest>().ReverseMap();
            CreateMap<GetLikeResponse, UpdateLikeRequest>().ReverseMap();


            //Responses
            CreateMap<Like, GetLikeResponse>().ReverseMap();
            CreateMap<Like, GetListLikeResponse>().ReverseMap();
            CreateMap<Paginate<Like>, Paginate<GetListLikeResponse>>().ReverseMap();
        }
    }
}
