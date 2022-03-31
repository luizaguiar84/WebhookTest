using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WebhookTest.Handlers;

namespace WebhookTest.Webhooks
{
    public class Yep : AcceptedHandler<HelloRequest>
    {
        private readonly ILogger<Yep> _logger;

        public Yep(ILogger<Yep> logger)
        {
            this._logger = logger;
        }
    
        public override Task Handle(HelloRequest request)
        {
            this._logger.LogInformation($"Hello, {request.Teste}");
            return Task.CompletedTask;
        }
    }
}