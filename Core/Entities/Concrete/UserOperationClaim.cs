namespace Core.Entities.Concrete
{
    public class UserOperationClaim : Entity<Guid>
    {

        public int UserId { get; set; }

        public int OperationClaimId { get; set; }
    }
}
