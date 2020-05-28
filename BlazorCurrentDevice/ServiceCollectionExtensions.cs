using Microsoft.Extensions.DependencyInjection;

namespace BlazorCurrentDevice
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers BlazorCurrentDeviceService into the service collection.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBlazorCurrentDevice(this IServiceCollection services)
        {
            return services.AddSingleton<IBlazorCurrentDeviceService, BlazorCurrentDeviceService>();
        }
    }
}
