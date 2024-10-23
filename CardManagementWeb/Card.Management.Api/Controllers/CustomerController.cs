using Card.Management.Application.DTOs;
using Card.Management.Application.Requests.commands.AddCustomer;
using Card.Management.Application.Requests.queries.CustomerQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Card.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<int> AddCustomer(AddCustomerCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<List<CustomerDto>> GetAll()
        {
            GetCustomer query = new GetCustomer();
            return await _mediator.Send(query);
        }
        [HttpGet("name")]
        public async Task<List<CustomerDto>>GetByName(string name)

            {
                GetCustomerByNameQuery query = new GetCustomerByNameQuery();    
                query.name = name;
                return await _mediator.Send(query);
            }

        [HttpGet("Customer details With Account Details")]
        public async Task<List<CustomerAccountDto>> GetCustomerWithAccount(int id)
        {
            GetCustomerWithAccountQuery query = new GetCustomerWithAccountQuery();
            query.id = id;
            return await _mediator.Send(query);
        }
        
    }
}
