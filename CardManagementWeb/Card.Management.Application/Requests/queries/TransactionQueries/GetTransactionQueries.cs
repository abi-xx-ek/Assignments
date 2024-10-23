using Card.Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.TransactionQueries
{
    public class GetTransactionQueries:IRequest<List<TransactionDto>>
    {
    }
}
