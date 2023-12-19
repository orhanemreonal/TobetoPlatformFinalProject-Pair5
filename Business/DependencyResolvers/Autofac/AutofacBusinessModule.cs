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

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<ClassRoomManager>().As<IClassRoomService>().SingleInstance();
            builder.RegisterType<EfClassRoomDal>().As<IClassRoomDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<CompetenceManager>().As<ICompetenceService>().SingleInstance();
            builder.RegisterType<EfCompetenceDal>().As<ICompetenceDal>().SingleInstance();

            builder.RegisterType<ExamManager>().As<IExamService>().SingleInstance();
            builder.RegisterType<EfExamDal>().As<IExamDal>().SingleInstance();

            builder.RegisterType<EducationManager>().As<IEducationService>().SingleInstance();
            builder.RegisterType<EfEducationDal>().As<IEducationDal>().SingleInstance();


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
