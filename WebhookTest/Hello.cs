using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WebhookTest
{
    public class Hello : ResponseHandler<HelloRequest, HelloResponse>
    {
        public async override Task<HelloResponse> Handle(HelloRequest request)
        {
            return new HelloResponse
            {
                Teste = "testado"
            };
        }
    }
    
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

    public class HelloResponse
    {
        public string Teste { get; set; }
    }

    public class HelloRequest
    {
        public string Teste { get; set; }
    }
}