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


            //Responses
            CreateMap<Like, GetLikeResponse>().ReverseMap();
            CreateMap<Paginate<Like>, Paginate<GetLikeResponse>>().ReverseMap();
        }
    }
}
