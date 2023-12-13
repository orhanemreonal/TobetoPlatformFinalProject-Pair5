using Business.Abstracts;
using Business.Concretes;
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
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<IClassCourseService, ClassCourseManager>();
            services.AddScoped<ICompetenceService, CompetenceManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExamService, ExamManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
