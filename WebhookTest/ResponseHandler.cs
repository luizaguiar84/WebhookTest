using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebhookTest
{
    [ApiController, Route("{prefix:webhookRoutePrefix}/[controller]")]
    public abstract class ResponseHandler<TRequest, TResponse>
    {
        [HttpPost, Route("")]
        public abstract Task<TResponse> Handle([FromBody] TRequest request);
    }
}