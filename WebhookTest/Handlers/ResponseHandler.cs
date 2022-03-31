using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebhookTest.Handlers
{
    [ApiController, Route("wh[controller]")]
    public abstract class ResponseHandler<TRequest, TResponse>
    {
        [HttpPost, Route("")]
        public abstract Task<TResponse> Handle([FromBody] TRequest request);
    }
}