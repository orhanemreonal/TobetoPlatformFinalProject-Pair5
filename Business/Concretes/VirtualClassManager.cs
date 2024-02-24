using AutoMapper;
using Business.Abstracts;
using Business.Dtos.VirtualClass.Requests;
using Business.Dtos.VirtualClass.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class VirtualClassManager : IVirtualClassService
    {
        IVirtualClassDal _virtualClassDal;
        IMapper _mapper;
        VirtualClassBusinessRules _businessRules;

        public VirtualClassManager(IVirtualClassDal virtualClassDal, IMapper mapper, VirtualClassBusinessRules businessRules)
        {
            _virtualClassDal = virtualClassDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetVirtualClassResponse> Add(CreateVirtualClassRequest request)
        {
            VirtualClass virtualClass = _mapper.Map<VirtualClass>(request);
            await _virtualClassDal.AddAsync(virtualClass);
            GetVirtualClassResponse response = _mapper.Map<GetVirtualClassResponse>(request);
            return response;
        }

        public async Task<GetVirtualClassResponse> Delete(DeleteVirtualClassRequest request)
        {
            VirtualClass virtualClass = await _virtualClassDal.GetAsync(predicate: vc => vc.Id == request.Id);

            await _businessRules.VirtualClassShouldExistWhenSelected(virtualClass);


            await _virtualClassDal.DeleteAsync(virtualClass);
            GetVirtualClassResponse response = _mapper.Map<GetVirtualClassResponse>(virtualClass);
            return response;
        }

        public async Task<GetVirtualClassResponse> Get(Guid id)
        {
            VirtualClass virtualClass = await _virtualClassDal.GetAsync(predicate: vc => vc.Id == id);

            await _businessRules.VirtualClassShouldExistWhenSelected(virtualClass);


            GetVirtualClassResponse response = _mapper.Map<GetVirtualClassResponse>(virtualClass);
            return response;
        }

        public async Task<IPaginate<GetListVirtualClassResponse>> GetList(PageRequest request)
        {
            var result = await _virtualClassDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListVirtualClassResponse> response = _mapper.Map<Paginate<GetListVirtualClassResponse>>(result);
            return response;
        }

        public async Task<GetVirtualClassResponse> Update(UpdateVirtualClassRequest request)
        {
            var result = await _virtualClassDal.GetAsync(predicate: a => a.Id == request.Id);
            await _businessRules.VirtualClassShouldExistWhenSelected(result);
            _mapper.Map(request, result);

            //await _businessRules.CheckIfVirtualClassNotExist(virtualClass);

            await _virtualClassDal.UpdateAsync(result);
            GetVirtualClassResponse response = _mapper.Map<GetVirtualClassResponse>(result);
            return response;

        }
    }
}
