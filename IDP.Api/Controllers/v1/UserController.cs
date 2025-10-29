using IDP.Api.Controllers.BaseController;
using IDP.application.Commands.user;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : IBaseController
    {
        public readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
                _mediator = mediator;
        }
        /// <summary>
        /// ورود اطلاعات کاربر 
        /// </summary>
        /// <returns></returns>
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody ] UserCommand userCommand)
        {
            _mediator.Send(userCommand);
            return Ok();
        } 
    }
}
