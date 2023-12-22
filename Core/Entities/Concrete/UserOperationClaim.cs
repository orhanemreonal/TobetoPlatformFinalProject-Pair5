namespace Core.Entities.Concrete
{
    public class UserOperationClaim : Entity<Guid>
    {

        public Guid UserId { get; set; }

        public Guid OperationClaimId { get; set; }
    }
}
