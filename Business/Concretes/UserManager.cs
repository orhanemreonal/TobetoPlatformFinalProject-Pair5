using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;
        IPersonalInformationDal _personalInformationDal;


        public UserManager(IUserDal userDal, IMapper mapper, IPersonalInformationDal personalInformationDal)
        {
            _userDal = userDal;
            _mapper = mapper;
            _personalInformationDal = personalInformationDal;
        }

        public async Task<GetUserResponse> Add(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);
            await _userDal.AddAsync(user);
            await _personalInformationDal.AddAsync(new PersonalInformation());
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;

        }

        public async Task<GetUserResponse> Delete(DeleteUserRequest request)
        {
            User user = await _userDal.GetAsync(predicate: u => u.Id == request.Id);
            await _userDal.DeleteAsync(user);
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;

        }

        public async Task<GetUserResponse> Get(Guid id)
        {
            User user = await _userDal.GetAsync(predicate: u => u.Id == id);
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;
        }

        public async Task<IPaginate<GetListUserResponse>> GetList(PageRequest request)
        {
            var result = await _userDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListUserResponse> response = _mapper.Map<Paginate<GetListUserResponse>>(result);
            return response;
        }

        public async Task<GetUserResponse> Update(UpdateUserRequest request)
        {
            User updatedUser = _mapper.Map<User>(request);
            await _userDal.UpdateAsync(updatedUser);
            GetUserResponse response = _mapper.Map<GetUserResponse>(updatedUser);
            return response;
        }
    }
}
