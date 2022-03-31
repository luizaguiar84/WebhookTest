using System.Threading.Tasks;
using WebhookTest.Handlers;

namespace WebhookTest.Webhooks
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
}