using Card.Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.CustomerQueries
{
    public class GetCustomerByNameQuery:IRequest<List<CustomerDto>>
    {
        public string name { get; set; }
    }
}
