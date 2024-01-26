using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Exam.Requests;
using Business.Dtos.Exam.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ExamManager : IExamService
    {
        IExamDal _examDal;
        IMapper _mapper;
        ExamBusinessRules _businessRules;

        public ExamManager(IExamDal examDal, IMapper mapper, ExamBusinessRules businessRules)
        {
            _examDal = examDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetExamResponse> Add(CreateExamRequest request)
        {
            Exam exam = _mapper.Map<Exam>(request);

            await _examDal.AddAsync(exam);
            GetExamResponse response = _mapper.Map<GetExamResponse>(exam);
            return response;
        }



        public async Task<GetExamResponse> Delete(DeleteExamRequest request)
        {
            Exam exam = await _examDal.GetAsync(predicate: u => u.Id == request.Id);

            await _businessRules.ExamShouldExistWhenSelected(exam);


            await _examDal.DeleteAsync(exam);
            GetExamResponse response = _mapper.Map<GetExamResponse>(exam);
            return response;

        }

        public async Task<GetExamResponse> Get(Guid id)
        {
            Exam exam = await _examDal.GetAsync(predicate: u => u.Id == id);

            await _businessRules.ExamShouldExistWhenSelected(exam);


            GetExamResponse response = _mapper.Map<GetExamResponse>(exam);
            return response;
        }

        public async Task<IPaginate<GetListExamResponse>> GetList(PageRequest request)
        {
            var result = await _examDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListExamResponse> response = _mapper.Map<Paginate<GetListExamResponse>>(result);
            return response;
        }

        public async Task<GetExamResponse> Update(UpdateExamRequest request)
        {
            var result = await _examDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.ExamShouldExistWhenSelected(result);
            await _examDal.UpdateAsync(result);
            GetExamResponse response = _mapper.Map<GetExamResponse>(result);
            return response;




        }
    }
}
