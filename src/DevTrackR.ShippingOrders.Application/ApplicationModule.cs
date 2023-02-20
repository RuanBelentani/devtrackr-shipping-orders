using DevTrackR.ShippingOrders.Application.Services;
using DevTrackR.ShippingOrders.Application.Subscribers;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrackR.ShippingOrders.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddSubscribers();
            
            return services;
        }

        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IShippingOrderService, ShippingOrderService>();
            services.AddScoped<IShippingServiceService, ShippingServiceService>();
            return services;
        }

        private static IServiceCollection AddSubscribers(this IServiceCollection services)
        {
            services.AddHostedService<ShippingOrderCompletedSubscriber>();

            return services;
        }
    }
}