using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Handlers;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Queries.Requests;

namespace Shop.Controllers;

    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {


        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromServices]IMediator mediator,
            [FromQuery]FindCustomerByIdRequest command
        )
        {
            var result = mediator.Send(command);
            return Ok(result);
        }


        [HttpPost]
        [Route("")]
        public IActionResult Create(
                   [FromServices]IMediator mediator,
                   [FromBody]CreateCustomerRequest command
               )
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }