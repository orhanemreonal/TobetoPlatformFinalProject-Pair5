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
            services.AddScoped<IClassroomCourseService, ClassroomCourseManager>();
            services.AddScoped<ICompetenceService, CompetenceManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICourseTopicService, CourseTopicManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExamService, ExamManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ILikeService, LikeManager>();
            services.AddScoped<IPersonalInformationService, PersonalInformationManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICompanyService, CompanyManager>();
            services.AddScoped<IClassroomService, ClassroomManager>();
            services.AddScoped<IStudentLanguageService, StudentLanguageManager>();
            services.AddScoped<IStudentLikeService, StudentLikeManager>();
            services.AddScoped<IClassAnnouncementService, ClassAnnouncementManager>();
            services.AddScoped<ITitleService, TitleManager>();
            services.AddScoped<ITopicService, TopicManager>();
            services.AddScoped<IVirtualClassService, VirtualClassManager>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
