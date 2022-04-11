using MediatR;
using Meo.Pesquisa.Domain.Commands.Requests;
using Meo.Pesquisa.Domain.Queries.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Controllers
{
    [ApiController]
    [Route("Forms")]
    public class FormController : Controller
    {
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateAsync([FromServices] IMediator mediator,
                   [FromBody] CreateFormRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetByIdAsync([FromServices] IMediator mediator,
            [FromQuery] FindFormByIdRequest command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("Answer")]
        public async Task<IActionResult> AnswerAsync([FromServices] IMediator mediator,
                   [FromBody] CreateAnswerRequest command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }

    }
}
