using Card.Management.Application.DTOs;
using Card.Management.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.queries.AccountQueries
{
    public class GetAccountQueryHandler: IRequestHandler<GetAccountQueries, List<AccountDto>>
    {

        private readonly CardManagementContext _context;

        public GetAccountQueryHandler(CardManagementContext context)
        {
            _context = context;
        }
        public async Task<List<AccountDto>> Handle(GetAccountQueries request, CancellationToken cancellationToken)
        {
            var r = await Task.Run(() =>
            {
                List<AccountDto> result = new List<AccountDto>();
                var Accounts = _context.Accounts;

                foreach (var Account in Accounts)
                {
                    AccountDto accountdto = new AccountDto();
                    accountdto.AccountNumber = Account.AccountNumber;
                    accountdto.Balance = Account.Balance;
                    accountdto.AccountType = Account.AccountType; 
                    accountdto.CustomerID = Account.CustomerID;


                    result.Add(accountdto);
                }

                return result;
            });

            return r;
        }
    }

}
