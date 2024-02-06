using Business.Abstract;
using Business.Abstracts;
using Business.Concrete;
using Business.Concretes;
using Business.Rules;
using Core.Utilities.Security.Jwt;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IAsyncVideoService, AsyncVideoManager>();
            services.AddScoped<ICertificateService, CertificateManager>();

            services.AddScoped<ICompetenceService, CompetenceManager>();
            services.AddScoped<ICourseService, CourseManager>();

            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExamService, ExamManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ILanguageLevelService, LanguageLevelManager>();
            services.AddScoped<ILikeService, LikeManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaStudentService, SocialMediaStudentManager>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<IClassroomService, ClassroomManager>();
            services.AddScoped<IStudentLanguageService, StudentLanguageManager>();

            services.AddScoped<ITitleService, TitleManager>();
            services.AddScoped<ITopicService, TopicManager>();
            services.AddScoped<IVirtualClassService, VirtualClassManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<ITokenHelper, JwtHelper>();

            services.AddScoped<AnnouncementBusinessRules>();
            services.AddScoped<ApplicationBusinessRules>();
            services.AddScoped<AsyncVideoBusinessRules>();
            services.AddScoped<CategoryBusinessRules>();
            services.AddScoped<CertificateBusinessRules>();

            services.AddScoped<ClassroomBusinessRules>();

            services.AddScoped<CompanyBusinessRules>();
            services.AddScoped<CompetenceBusinessRules>();
            services.AddScoped<CourseBusinessRules>();

            services.AddScoped<EducationBusinessRules>();
            services.AddScoped<ExamBusinessRules>();
            services.AddScoped<ExperienceBusinessRules>();
            services.AddScoped<InstructorBusinessRules>();
            services.AddScoped<LanguageBusinessRules>();
            services.AddScoped<LanguageLevelBusinessRules>();
            services.AddScoped<LikeBusinessRules>();
            services.AddScoped<PersonalInformationBusinessRules>();

            services.AddScoped<SocialMediaBusinessRules>();
            services.AddScoped<SocialMediaStudentBusinessRules>();
            services.AddScoped<StudentBusinessRules>();
            services.AddScoped<StudentLanguageBusinessRules>();
            services.AddScoped<PersonalInformationBusinessRules>();


            services.AddScoped<SurveyBusinessRules>();
            services.AddScoped<TitleBusinessRules>();
            services.AddScoped<TopicBusinessRules>();
            services.AddScoped<UserBusinessRules>();
            services.AddScoped<VirtualClassBusinessRules>();


            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
