using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            //builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>().SingleInstance();
            //builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>().SingleInstance();

            //builder.RegisterType<ApplicationManager>().As<IApplicationService>().SingleInstance();
            //builder.RegisterType<EfApplicationDal>().As<IApplicationDal>().SingleInstance();

            //builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            //builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();


            //builder.RegisterType<CertificateManager>().As<ICertificateService>().SingleInstance();
            //builder.RegisterType<EfCertificateDal>().As<ICertificateDal>().SingleInstance();

            //builder.RegisterType<ClassAnnouncementManager>().As<IClassAnnouncementService>().SingleInstance();
            //builder.RegisterType<EfClassAnnouncementDal>().As<IClassAnnouncementDal>().SingleInstance();

            //builder.RegisterType<ClassroomCourseManager>().As<IClassroomCourseService>().SingleInstance();
            //builder.RegisterType<EfClassroomCourseDal>().As<IClassroomCourseDal>().SingleInstance();

            //builder.RegisterType<ClassroomManager>().As<IClassroomService>().SingleInstance();
            //builder.RegisterType<EfClassroomDal>().As<IClassroomDal>().SingleInstance();


            //builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            //builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            //builder.RegisterType<CompetenceManager>().As<ICompetenceService>().SingleInstance();
            //builder.RegisterType<EfCompetenceDal>().As<ICompetenceDal>().SingleInstance();


            //builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            //builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();

            //builder.RegisterType<EducationManager>().As<IEducationService>().SingleInstance();
            //builder.RegisterType<EfEducationDal>().As<IEducationDal>().SingleInstance();

            //builder.RegisterType<ExamManager>().As<IExamService>().SingleInstance();
            //builder.RegisterType<EfExamDal>().As<IExamDal>().SingleInstance();

            //builder.RegisterType<PersonalInformationManager>().As<IPersonalInformationService>().SingleInstance();
            //builder.RegisterType<EfPersonalInformationDal>().As<IPersonalInformationDal>().SingleInstance();

            //builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>().SingleInstance();
            //builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>().SingleInstance();

            //builder.RegisterType<StudentLanguageManager>().As<IStudentLanguageService>().SingleInstance();
            //builder.RegisterType<EfStudentLanguageDal>().As<IStudentLanguageDal>().SingleInstance();

            //builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            //builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();

            //builder.RegisterType<SurveyManager>().As<ISurveyService>().SingleInstance();
            //builder.RegisterType<EfSurveyDal>().As<ISurveyDal>().SingleInstance();

            //builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            //builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            //builder.RegisterType<SurveyManager>().As<ISurveyService>().SingleInstance();
            //builder.RegisterType<EfSurveyDal>().As<ISurveyDal>().SingleInstance();

            //builder.RegisterType<InstructorManager>().As<IInstructorService>().SingleInstance();
            //builder.RegisterType<EfInstructorDal>().As<IInstructorDal>().SingleInstance();

            //builder.RegisterType<ExperienceManager>().As<IExperienceService>().SingleInstance();
            //builder.RegisterType<EfExperienceDal>().As<IExperienceDal>().SingleInstance();

            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
