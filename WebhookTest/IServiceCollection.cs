using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace WebhookTest
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddWebhooks(this IServiceCollection services,
            Action<WebhookOptions> spaceAction = null)
        {
            var options = new WebhookOptions();

            services.Configure<RouteOptions>(opt =>
            {
                opt.ConstraintMap.Add("webhookRoutePrefix", typeof(WebhookRoutePrefixConstraint));
            });
            spaceAction?.Invoke(options);
            services.AddSingleton(options);

            return services;
        }
    }
}