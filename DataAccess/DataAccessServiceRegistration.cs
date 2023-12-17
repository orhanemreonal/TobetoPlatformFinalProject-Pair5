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
            services.AddDbContext<TobetoPlatformContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatform")));

            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<IClassCourseDal, EfClassCourseDal>();
            services.AddScoped<ICompetenceDal, EfCompetenceDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<IExamDal, EfExamDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ILanguageDal, EfLanguageDal>();
            services.AddScoped<IPersonalInformationDal, EfPersonalInformationDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<IStudentDal, EfStudentDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICompanyDal, EfCompanyDal>();
            services.AddScoped<IClassRoomDal, EfClassRoomDal>();
            services.AddScoped<IStudentLanguageDal, EfStudentLanguageDal>();
            services.AddScoped<IClassAnnouncementDal, EfClassAnnouncementDal>();



            return services;
        }
    }
}
