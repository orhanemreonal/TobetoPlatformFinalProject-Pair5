using AutoMapper;
using Business.Abstracts;
using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.PersonelInformations.Responses;
using Business.Dtos.SocialMedias.Responses;
using Business.Dtos.Students.Requests;
using Business.Dtos.Students.Responses;
using Business.Dtos.Users.Requests;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class StudentLanguageManager : IStudentLanguageService
    {
        IStudentLanguageDal _studentLanguageDal;
        IMapper _mapper;

        public StudentLanguageManager(IStudentLanguageDal studentLanguageDal, IMapper mapper)
        {
            _studentLanguageDal = studentLanguageDal;
            _mapper = mapper;
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
            await _studentLanguageDal.DeleteAsync(studentLanguage);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }

        public async Task<GetStudentLanguageResponse> Get(Guid id)
        {
            StudentLanguage studentLanguage = await _studentLanguageDal.GetAsync(predicate: u => u.Id == id);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }

        public async Task<IPaginate<GetListStudentLanguageResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _studentLanguageDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
            Paginate<GetListStudentLanguageResponse> response = _mapper.Map<Paginate<GetListStudentLanguageResponse>>(result);
            return response;
        }

        public async Task<GetStudentLanguageResponse> Update(UpdateStudentLanguageRequest updateStudentLanguageRequest)
        {
            StudentLanguage studentLanguage = _mapper.Map<StudentLanguage>(updateStudentLanguageRequest);
            await _studentLanguageDal.UpdateAsync(studentLanguage);
            GetStudentLanguageResponse response = _mapper.Map<GetStudentLanguageResponse>(studentLanguage);
            return response;
        }
    }
}
