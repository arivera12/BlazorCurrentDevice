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
            // we want it scoped so it can be used in blazor Server
            // For Blazor WebAssembly, a Scoped service is the same as a Singleton service. 
            return services.AddScoped<IBlazorCurrentDeviceService, BlazorCurrentDeviceService>();
        }
    }
}
