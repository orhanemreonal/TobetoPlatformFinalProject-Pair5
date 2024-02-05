using AutoMapper;
using Business.Abstracts;
using Business.Dtos.StudentLanguage.Requests;
using Business.Dtos.Students.Requests;
using Business.Dtos.Students.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class StudentLanguageManager : IStudentLanguageService
    {
        IStudentLanguageDal _studentLanguageDal;
        IMapper _mapper;
        StudentLanguageBusinessRules _businessRules;

        public StudentLanguageManager(IStudentLanguageDal studentLanguageDal, IMapper mapper, StudentLanguageBusinessRules businessRules)
        {
            _studentLanguageDal = studentLanguageDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetStudentLanguageResponse> Add(CreateStudentLanguageRequest createStudentLanguageRequest)
        {
            StudentLanguage studentLanguage = _mapper.Map<StudentLanguage>(createStudentLanguageRequest);

            await _studentLanguageDal.AddAsync(studentLanguage);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }

        public async Task<GetStudentLanguageResponse> Delete(DeleteStudentLanguageRequest deleteStudentLanguageRequest)
        {
            StudentLanguage studentLanguage = await _studentLanguageDal.GetAsync(predicate: u => u.Id == deleteStudentLanguageRequest.Id);
            await _businessRules.StudentLanguageShouldExistWhenSelected(studentLanguage);
            await _studentLanguageDal.DeleteAsync(studentLanguage);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }

        public async Task<GetStudentLanguageResponse> Get(Guid id)
        {
            StudentLanguage studentLanguage = await _studentLanguageDal.GetAsync(
                predicate: u => u.Id == id,
                include: x => x.Include(sl => sl.Language).Include(sl => sl.LanguageLevel).Include(sl => sl.Student));

            await _businessRules.StudentLanguageShouldExistWhenSelected(studentLanguage);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }

        public async Task<IPaginate<GetListStudentLanguageResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _studentLanguageDal.GetListAsync(
                index: pageRequest.Index,
                size: pageRequest.Size,
                include: x => x.Include(sl => sl.Language).Include(sl => sl.LanguageLevel).Include(sl => sl.Student)
                );
            Paginate<GetListStudentLanguageResponse> response = _mapper.Map<Paginate<GetListStudentLanguageResponse>>(result);
            return response;
        }
        public async Task<IPaginate<GetListStudentLanguageResponse>> GetListByStudent(GetStudentLanguagesByStudentRequest request)
        {
            var result = await _studentLanguageDal.GetListAsync(
                index: request.Index,
                size: request.Size,
                predicate: x => x.StudentId == request.StudentId,
                include: x => x.Include(sl => sl.Language).Include(sl => sl.LanguageLevel).Include(sl => sl.Student)
                );
            Paginate<GetListStudentLanguageResponse> response = _mapper.Map<Paginate<GetListStudentLanguageResponse>>(result);
            return response;
        }

        public async Task<GetStudentLanguageResponse> Update(UpdateStudentLanguageRequest request)
        {
            var result = await _studentLanguageDal.GetAsync(predicate: a => a.Id == request.Id);
            await _businessRules.StudentLanguageShouldExistWhenSelected(result);
            _mapper.Map(request, result);
            //await _businessRules.CheckIfStudentLanguageNotExist(result);
            await _studentLanguageDal.UpdateAsync(result);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(result);
            return response;

        }
    }
}
