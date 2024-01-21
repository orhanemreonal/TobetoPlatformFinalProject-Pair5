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

        public Task CheckIfVirtualClassNotExist(VirtualClass? virtualClass)
        {
            if (virtualClass == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfVirtualClassExist(VirtualClass? virtualClass)
        {
            if (virtualClass != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfVirtualClassNotExist(Guid id)
        {
            VirtualClass virtualClass = _virtualClassDal.Get(a => a.Id == id);
            CheckIfVirtualClassNotExist(virtualClass);
        }
    }
}
