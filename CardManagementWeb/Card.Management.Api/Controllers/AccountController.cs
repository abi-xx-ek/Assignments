using Card.Management.Application.DTOs;
using Card.Management.Application.Requests.commands.AddAccounts;
using Card.Management.Application.Requests.commands.AddCustomer;
using Card.Management.Application.Requests.queries.AccountQueries;
using Card.Management.Application.Requests.queries.CustomerQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Card.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<int> AddAccount(AddAccountCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<List<AccountDto>> GetAll()
        {
            GetAccountQueries query = new GetAccountQueries();
            return await _mediator.Send(query);
        }
        [HttpGet("AccountID")]
        public async Task<List<AccountDto>> GetById(int getid)
        { 
            GetAccountByIDQuery query = new GetAccountByIDQuery();
            query.getid = getid;
           
            return await _mediator.Send(query);
        }

    }
}
