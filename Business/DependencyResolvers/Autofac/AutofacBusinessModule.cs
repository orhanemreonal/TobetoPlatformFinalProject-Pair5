using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {



            builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>().SingleInstance();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>().SingleInstance();

            builder.RegisterType<ApplicationManager>().As<IApplicationService>().SingleInstance();
            builder.RegisterType<EfApplicationDal>().As<IApplicationDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();

            builder.RegisterType<SurveyManager>().As<ISurveyService>().SingleInstance();
            builder.RegisterType<EfSurveyDal>().As<ISurveyDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<PersonalInformationManager>().As<IPersonalInformationService>().SingleInstance();
            builder.RegisterType<EfPersonalInformationDal>().As<IPersonalInformationDal>().SingleInstance();
            builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>().SingleInstance();
            builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>().SingleInstance();
            builder.RegisterType<StudentLanguageManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();

          

            builder.RegisterType<ClassCourseManager>().As<IClassCourseService>().SingleInstance();
            builder.RegisterType<EfClassCourseDal>().As<IClassCourseDal>().SingleInstance();

            builder.RegisterType<CertificateManager>().As<ICertificateService>().SingleInstance();
            builder.RegisterType<EfCertificateDal>().As<ICertificateDal>().SingleInstance();

            builder.RegisterType<ClassAnnouncementManager>().As<IClassAnnouncementService>().SingleInstance();
            builder.RegisterType<EfClassAnnouncementDal>().As<IClassAnnouncementDal>().SingleInstance();
            builder.RegisterType<PersonalInformationManager>().As<IPersonalInformationService>().SingleInstance();
            builder.RegisterType<EfPersonalInformationDal>().As<IPersonalInformationDal>().SingleInstance();
            builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>().SingleInstance();
            builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>().SingleInstance();
            builder.RegisterType<StudentLanguageManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();


            builder.RegisterType<ClassCourseManager>().As<IClassCourseService>().SingleInstance();
            builder.RegisterType<EfClassCourseDal>().As<IClassCourseDal>().SingleInstance();

            builder.RegisterType<CertificateManager>().As<ICertificateService>().SingleInstance();
            builder.RegisterType<EfCertificateDal>().As<ICertificateDal>().SingleInstance();

            builder.RegisterType<ClassAnnouncementManager>().As<IClassAnnouncementService>().SingleInstance();
            builder.RegisterType<EfClassAnnouncementDal>().As<IClassAnnouncementDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
