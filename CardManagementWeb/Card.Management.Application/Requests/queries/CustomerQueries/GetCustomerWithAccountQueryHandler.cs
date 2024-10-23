using Card.Management.Application.DTOs;
using Card.Management.Domain.Entity;
using Card.Management.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.CustomerQueries
{
    public class GetCustomerWithAccountQueryHandler : IRequestHandler<GetCustomerWithAccountQuery, List<CustomerAccountDto>>
    {
        private readonly CardManagementContext _context;

        public GetCustomerWithAccountQueryHandler(CardManagementContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerAccountDto>> Handle(GetCustomerWithAccountQuery request, CancellationToken cancellationToken)
        {
            var re = await Task.Run(() =>
            {
                List<CustomerAccountDto> customerAccountDtos = new List<CustomerAccountDto>();

                var customer = _context.Customers.Include(x => x.accounts).Where(x=>x.Id.Equals(request.id));
                foreach (var cus in customer)
                {
                    CustomerAccountDto customerAccountDto = new CustomerAccountDto();
                    customerAccountDto.Id = cus.Id;
                    customerAccountDto.Name = cus.CustomerName;
                    customerAccountDto.Email = cus.Email;
                    var Account = cus.accounts;
                    List<AccountDto> accountlist = new List<AccountDto>();
                    foreach (var acc in Account)
                    {
                        AccountDto accountdto = new AccountDto();
                        accountdto.AccountNumber = acc.AccountNumber;
                        accountdto.Balance = acc.Balance;
                        accountdto.AccountType = acc.AccountType;
                        accountlist.Add(accountdto);
                    }
                    customerAccountDto.Account = accountlist;
                    customerAccountDtos.Add(customerAccountDto);
                }
                return customerAccountDtos;
            });
            return re;
        }
    }
}
