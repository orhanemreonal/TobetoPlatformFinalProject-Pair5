using AutoMapper;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;

namespace Business.Profiles
{
    public class UserMappingProfiles : Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<User, CreateUserRequest>().ReverseMap();
            CreateMap<User, DeleteUserRequest>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();

            CreateMap<User, GetUserResponse>().ReverseMap();
            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();

        }
    }
}
