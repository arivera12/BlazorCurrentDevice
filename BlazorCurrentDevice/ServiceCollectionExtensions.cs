using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace BlazorCurrentDevice
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorCurrentDevice(this IServiceCollection services)
        {
            return services.AddSingleton((service) =>
            {
                var JSRuntime = service.GetRequiredService<IJSRuntime>();
                return new BlazorCurrentDevice(JSRuntime);
            });
        }
    }
}
