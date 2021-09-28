using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopWithCQRS.Domain.Command.Requests;

namespace ShopWithCQRS.Controllers
{
    [Route("v1/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromServices] IMediator mediator,
                                  [FromBody] CreateCustomerRequest command)
        {
            return Ok(mediator.Send(command).Result);
        }
    }
}
