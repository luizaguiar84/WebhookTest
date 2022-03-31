using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WebhookTest.Handlers;

namespace WebhookTest.Webhooks
{
    public class Yep : AcceptedHandler<HelloRequest>
    {
        private readonly ILogger<Yep> logger;

        public Yep(ILogger<Yep> logger)
        {
            this.logger = logger;
        }
    
        public override Task Handle(HelloRequest request)
        {
            this.logger.LogInformation($"Hello, {request.Teste}");
            return Task.CompletedTask;
        }
    }
}