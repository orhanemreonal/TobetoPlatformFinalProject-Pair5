using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;
        UserBusinessRules _businessRules;

        public UserManager(IUserDal userDal, IMapper mapper, UserBusinessRules businessRules)
        {
            _userDal = userDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }



        //[ValidationAspect(typeof(UserRequestValidator))]
        public async Task<GetUserResponse> Add(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);

            // Böyle bir kullanıcı var mı?
            //await _businessRules.CheckIfUserExist(user);

            await _userDal.AddAsync(user);
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;

        }


        public async Task<GetUserResponse> Delete(DeleteUserRequest request)
        {
            User user = await _userDal.GetAsync(predicate: u => u.Id == request.Id);

            await _businessRules.CheckIfUserNotExist(user);

            await _userDal.DeleteAsync(user);
            GetUserResponse response = _mapper.Map<GetUserResponse>(user);
            return response;

        }

        public async Task<GetUserResponse> Get(Guid id)
        {
            User user = await _userDal.GetAsync(predicate: u => u.Id == id);

            await _businessRules.CheckIfUserNotExist(user);

            GetUserResponse response = _mapper.Map<GetUserResponse>(user);

            return response;
        }

        public async Task<GetUserResponse> GetByMail(string email)
        {
            var gettedUser = await _userDal.GetAsync(u => u.Email == email);
            GetUserResponse response = _mapper.Map<GetUserResponse>(gettedUser);
            return response;
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            return await _userDal.GetClaims(user);
        }

        public async Task<IPaginate<GetListUserResponse>> GetList(PageRequest request)
        {
            var result = await _userDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListUserResponse> response = _mapper.Map<Paginate<GetListUserResponse>>(result);
            return response;
        }

        public async Task<GetUserResponse> Update(UpdateUserRequest request)
        {
            var result = await _userDal.GetAsync(predicate: c => c.Id == request.Id);
            _mapper.Map(request, result);

            await _businessRules.CheckIfUserNotExist(result);

            await _userDal.UpdateAsync(result);
            GetUserResponse response = _mapper.Map<GetUserResponse>(result);
            return response;
        }
    }
}
