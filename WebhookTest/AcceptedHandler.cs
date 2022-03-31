using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebhookTest
{
    [ApiController, Route("{prefix:webhookRoutePrefix}/[controller]"), Status(HttpStatusCode.Accepted)]
    public abstract class AcceptedHandler<TRequest>
    {
        [HttpPost, Route("")]
        public abstract Task Handle([FromBody] TRequest request);
    }
    
    public class Status : ActionFilterAttribute
    {
        private readonly HttpStatusCode statusCode;

        public Status(HttpStatusCode statusCode)
        {
            this.statusCode = statusCode;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = new StatusCodeResult((int) statusCode);
        }
    }
    
}