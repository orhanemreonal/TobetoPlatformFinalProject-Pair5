using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Competence.Requests;
using Business.Dtos.Competence.Responses;
using Business.Rules;
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
        CompetenceBusinessRules _businessRules;

        public CompetenceManager(ICompetenceDal competenceDal, IMapper mapper, CompetenceBusinessRules businessRules)
        {
            _competenceDal = competenceDal;
            _mapper = mapper;
            _businessRules = businessRules;
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
            await _businessRules.CompetenceShouldExistWhenSelected(competence);

            await _competenceDal.DeleteAsync(competence);
            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(competence);
            return response;
        }

        public async Task<GetCompetenceResponse> Get(Guid id)
        {
            Competence competence = await _competenceDal.GetAsync(predicate: cm => cm.Id == id);

            await _businessRules.CompetenceShouldExistWhenSelected(competence);

            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(competence);
            return response;
        }

        public async Task<IPaginate<GetListCompetenceResponse>> GetList(PageRequest request)
        {
            var result = await _competenceDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCompetenceResponse> response = _mapper.Map<Paginate<GetListCompetenceResponse>>(result);
            return response;
        }
        public async Task<IPaginate<GetListCompetenceResponse>> GetListByStudent(GetListByStudentRequest request)
        {
            var result = await _competenceDal.GetListAsync(index: request.Index, size: request.Size, predicate: (x => x.StudentId == request.StudentId));
            Paginate<GetListCompetenceResponse> response = _mapper.Map<Paginate<GetListCompetenceResponse>>(result);
            return response;
        }

        public async Task<GetCompetenceResponse> Update(UpdateCompetenceRequest request)
        {
            var result = await _competenceDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);

            await _businessRules.CompetenceShouldExistWhenSelected(result);
            await _competenceDal.UpdateAsync(result);
            GetCompetenceResponse response = _mapper.Map<GetCompetenceResponse>(result);
            return response;





        }
    }
}
