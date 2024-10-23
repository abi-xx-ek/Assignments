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
    public class GetCustomerByNameQueryHandler : IRequestHandler<GetCustomerByNameQuery, List<CustomerDto>>
    {
        private readonly CardManagementContext _context;

        public GetCustomerByNameQueryHandler(CardManagementContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerDto>> Handle(GetCustomerByNameQuery request, CancellationToken cancellationToken)
        {
            List<CustomerDto> result = new List<CustomerDto>();
            var re = await Task.Run(() =>
            {
                var customer = _context.Customers.Where(x => x.CustomerName.Contains(request.name));
                foreach(var cus in customer)
                {
                    CustomerDto dto = new CustomerDto();
                    dto.Id = cus.Id;
                    dto.Name = cus.CustomerName;
                    dto.Email= cus.Email;
                    result.Add(dto);
                }
                return result ;
            });
            return re;
        }
    }
}
