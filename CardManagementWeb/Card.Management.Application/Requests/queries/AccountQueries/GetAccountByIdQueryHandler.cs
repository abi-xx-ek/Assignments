using Card.Management.Application.DTOs;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.AccountQueries
{
    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIDQuery, List<AccountDto>>
    {
        private readonly CardManagementContext _context;

        public GetAccountByIdQueryHandler(CardManagementContext context)
        {
            _context = context;
        }

        public async Task<List<AccountDto>> Handle(GetAccountByIDQuery request, CancellationToken cancellationToken)
        {
            List<AccountDto> result = new List<AccountDto>();
            var re = await Task.Run(() =>
            {
                var account = _context.Accounts.Where(x => x.Id.Equals(request.getid));
                foreach (var acc in account)
                {
                    AccountDto accountDto = new AccountDto();
                    accountDto.AccountType = acc.AccountType;
                    accountDto.AccountNumber = acc.AccountNumber;
                    accountDto.Balance = acc.Balance;
                    accountDto.CustomerID = acc.CustomerID;

                    result.Add(accountDto);
                }

                return result;
            });
            return re;

        }
    }
}
