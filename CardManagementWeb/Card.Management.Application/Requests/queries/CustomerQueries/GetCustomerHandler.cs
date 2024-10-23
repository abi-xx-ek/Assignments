using Card.Management.Application.DTOs;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.CustomerQueries
{
    public class GetCustomerHandler : IRequestHandler<GetCustomer, List<CustomerDto>>
    {
        private readonly CardManagementContext _context;

        public GetCustomerHandler(CardManagementContext context)
        {
            _context = context;
        }
        public async Task<List<CustomerDto>> Handle(GetCustomer request, CancellationToken cancellationToken)
        {
            var r = await Task.Run(() =>
            {
                List<CustomerDto> result = new List<CustomerDto>();
                var customers = _context.Customers;

                foreach (var customer in customers)
                {
                    CustomerDto customerDto = new CustomerDto();
                    customerDto.Id = customer.Id;
                    customerDto.Name = customer.CustomerName;
                    customerDto.Email = customer.Email;
                    result.Add(customerDto);
                }

                return result;
            });

            return r;
        }
    }
}
