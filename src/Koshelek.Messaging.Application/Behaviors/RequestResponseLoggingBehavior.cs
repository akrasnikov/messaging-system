using MediatR;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Koshelek.Messaging.Application.Behaviors
{
    public class RequestResponseLoggingBehavior<TRequest, TResponse> :
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        private readonly ILogger<RequestResponseLoggingBehavior<TRequest, TResponse>> _logger;

        public RequestResponseLoggingBehavior(ILogger<RequestResponseLoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var correlationId = Guid.NewGuid();

            _logger.LogInformation("Handling request {CorrelationID}: {Request}",
                correlationId,
                JsonSerializer.Serialize(request));

            var response = await next();

            _logger.LogInformation("Response for {Correlation}: {Response}",
                correlationId,
                JsonSerializer.Serialize(response));


            return response;
        }
    }
}
