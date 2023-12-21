using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        // bununla injection altyapımızı okuyabiliyoruz autofac'teki
        // .netin servislerini kullanarak build et.
        // wepapi de oluşturduğumuz injectionları oluşturabilmemize yarar burası
        // bundan sonra istediğimiz herhangi bir interface in karşılığını bu tool vasıtasıyla alabiliriz.
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
