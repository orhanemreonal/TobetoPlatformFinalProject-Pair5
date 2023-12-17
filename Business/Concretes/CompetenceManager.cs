using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Competence.Requests;
using Business.Dtos.Competence.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CompetenceManager : ICompetenceService
    {
        ICompetenceDal _competenceDal;
        IMapper _mapper;

        public CompetenceManager(ICompetenceDal competenceDal, IMapper mapper)
        {
            _competenceDal = competenceDal;
            _mapper = mapper;
        }

        public async Task<GetCompetenceResponse> Add(CreateCompetenceRequest request)
        {
            Competence competence = _mapper.Map<Competence>(request);
            await _competenceDal.AddAsync(competence);

            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(competence);
            return response;
        }

        public async Task<GetCompetenceResponse> Delete(DeleteCompetenceRequest request)
        {
            Competence competence = await _competenceDal.GetAsync(predicate: cm => cm.Id == request.Id);
            await _competenceDal.DeleteAsync(competence);
            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(competence);
            return response;
        }

        public async Task<GetCompetenceResponse> Get(Guid id)
        {
            Competence competence = await _competenceDal.GetAsync(predicate: cm => cm.Id == id);
            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(competence);
            return response;
        }

        public async Task<IPaginate<GetListCompetenceResponse>> GetList(PageRequest request)
        {
            var result = await _competenceDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCompetenceResponse> response = _mapper.Map<Paginate<GetListCompetenceResponse>>(result);
            return response;
        }

        public async Task<GetCompetenceResponse> Update(UpdateCompetenceRequest request)
        {
            Competence updatedCompetence = _mapper.Map<Competence>(request);

            await _competenceDal.UpdateAsync(updatedCompetence);
            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(updatedCompetence);
            return response;
        }
    }
}
