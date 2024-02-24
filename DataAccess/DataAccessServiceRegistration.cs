using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<CourseAcademyContext>(options => options.UseInMemoryDatabase("nArchitecture"));
            services.AddDbContext<TobetoPlatformContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatform")), contextLifetime: ServiceLifetime.Transient);

            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IAsyncVideoDal, EfAsyncVideoDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<IClassAnnouncementDal, EfClassAnnouncementDal>();
            services.AddScoped<IClassroomCourseDal, EfClassroomCourseDal>();
            services.AddScoped<IClassroomDal, EfClassroomDal>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();
            services.AddScoped<ICompetenceDal, EfCompetenceDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICourseTopicDal, EfCourseTopicDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<IExamDal, EfExamDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ILanguageDal, EfLanguageDal>();
            services.AddScoped<ILanguageLevelDal, EfLanguageLevelDal>();
            services.AddScoped<ILikeDal, EfLikeDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaStudentDal, EfSocialMediaStudentDal>();
            services.AddScoped<IStudentDal, EfStudentDal>();
            services.AddScoped<IStudentLanguageDal, EfStudentLanguageDal>();
            services.AddScoped<IStudentLikeDal, EfStudentLikeDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<ITopicDal, EfTopicDal>();
            services.AddScoped<ITitleDal, EfTitleDal>();
            services.AddScoped<IVirtualClassDal, EfVirtualClassDal>();


            return services;
        }
    }
}
