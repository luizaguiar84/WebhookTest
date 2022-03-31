using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace WebhookTest
{
    public class WebhookOptions
    {
        public string RoutePrefix { get; set; } = "webhooks";
        
    }
}
    
    