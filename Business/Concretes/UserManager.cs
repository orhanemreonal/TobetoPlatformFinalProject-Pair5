using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System.ComponentModel.DataAnnotations;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserRequestValidator))]
        public async Task<GetUserResponse> Add(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);
            await _userDal.AddAsync(user);
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
