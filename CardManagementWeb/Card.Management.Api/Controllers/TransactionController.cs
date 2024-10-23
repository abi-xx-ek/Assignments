using Card.Management.Application.DTOs;
using Card.Management.Application.Requests.commands.AddTransactions;
using Card.Management.Application.Requests.queries.TransactionQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Card.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]

        public async Task<int>AddTransaction(AddTransactionCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpGet]

        public async Task<List<TransactionDto>>GetAll()
        {
            GetTransactionQueries query = new GetTransactionQueries();
            return await _mediator.Send(query);
        }
    }
}
