using Koshelek.Messaging.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Koshelek.Messaging.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MessagesController(IMediator mediator) => _mediator = mediator;

        [ProducesResponseType(typeof(Response<OrderModel>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost()]
        public IActionResult CreateMessage([FromBody] CreateMessagesCommand commabd)
        {

            return Created();
        }

        [ProducesResponseType(typeof(Ok<Message>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("/range")]
        public IActionResult GetMessages([FromQuery] GetMessagesQuery query)
        {
            TypedResults.Ok(query);


            return Ok();
        }

    }

    public class CreateMessagesCommandHandler : IRequestHandler<CreateMessagesCommand, uint>
    {

        public CreateMessagesCommandHandler()
        {

        }

        public Task<uint> Handle(CreateMessagesCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetMessagesQueryCommandHandler : IRequestHandler<GetMessagesQuery, IReadOnlyList<Message>>
    {

        public GetMessagesQueryCommandHandler()
        {

        }

        public Task<IReadOnlyList<Message>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateMessagesCommand : IRequest<uint>
    {
        public int Id { get; init; }
        public string Text { get; init; } = string.Empty;
    }

    public class GetMessagesQuery : IRequest<IReadOnlyList<Message>>
    {
        public DateTime From { get; init; }
        public DateTime To { get; init; }

        public int PageNumber { get; init; }
        public int PageSize { get; init; }

    }
}
