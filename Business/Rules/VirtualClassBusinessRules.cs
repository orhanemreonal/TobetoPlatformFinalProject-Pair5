using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class VirtualClassBusinessRules : BaseBusinessRules
    {
        IVirtualClassDal _virtualClassDal;

        public VirtualClassBusinessRules(IVirtualClassDal virtualClassDal)
        {
            _virtualClassDal = virtualClassDal;
        }

        public Task VirtualClassShouldExistWhenSelected(VirtualClass? virtualClass)
        {
            if (virtualClass == null)
                throw new BusinessException(Messages.VirtualClassNotExists);
            return Task.CompletedTask;
        }

        public async Task VirtualClassIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            VirtualClass? virtualClass = await _virtualClassDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await VirtualClassShouldExistWhenSelected(virtualClass);
        }
    }
}
