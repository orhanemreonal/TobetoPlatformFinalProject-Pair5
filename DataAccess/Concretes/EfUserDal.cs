using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Context;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformContext>, IUserDal
    {

        public EfUserDal(TobetoPlatformContext context) : base(context)
        {

        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {

            var result = from operationClaim in Context.OperationClaims
                         join userOperationClaim in Context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();


        }
    }

    //    public class EfUserDal : EfEntityRepositoryBase<User, TobetoPlatformContext>, IUserDal
    //    {
    //        public List<OperationClaim> GetClaims(User user)
    //        {
    //            using (var context = new TobetoPlatformContext())
    //            {
    //                var result = from operationClaim in context.OperationClaims
    //                             join userOperationClaim in context.UserOperationClaims
    //                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
    //                             where userOperationClaim.UserId == user.Id
    //                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
    //                return result.ToList();

    //            }
    //        }
    //    }
    //}
}
