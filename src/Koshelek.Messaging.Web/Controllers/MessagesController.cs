using Koshelek.Messaging.Application.Messages.Commands;
using Koshelek.Messaging.Application.Messages.Queries;
using Koshelek.Messaging.Domain;
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

        [ProducesResponseType(typeof(CreateMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BadRequest), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("message")]
        public IActionResult CreateMessage([FromBody] CreateMessageCommand command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }


        //[ProducesResponseType(typeof(CreateResponse), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(BadRequest), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpPost("message/test")]
        //public IActionResult  Text([FromBody] CreateCommand<Text> command)
        //{
        //    var result = _mediator.Send(command);
        //    return Ok(result);
        //}


        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("/range")]
        public IActionResult GetMessages([FromQuery] GetMessagesQuery query)
        {
            var result = _mediator.Send(query);
            return Ok();
        }

    }
}
