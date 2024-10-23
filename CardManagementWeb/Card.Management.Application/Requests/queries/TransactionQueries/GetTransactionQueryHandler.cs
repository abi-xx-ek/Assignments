using Card.Management.Application.DTOs;
using Card.Management.Application.Requests.queries.AccountQueries;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Card.Management.Application.Requests.queries.TransactionQueries
{
    public class GetTransactionQueryHandler:IRequestHandler<GetTransactionQueries,List<TransactionDto>>
    {
        private readonly CardManagementContext _context;

        public GetTransactionQueryHandler(CardManagementContext context)
        {
            _context = context;
        }
        public async Task<List<TransactionDto>> Handle(GetTransactionQueries request, CancellationToken cancellationToken)

        {

            var r = await Task.Run(() =>
            {
                List<TransactionDto> result = new List<TransactionDto>();
                var Transaction = _context.Transactions;

                foreach (var transactions in Transaction)
                {
                    TransactionDto transactiondto = new TransactionDto();
                    transactiondto.TransactionDate = transactions.TransactionDate;
                    transactiondto.transactionType = transactions.transactionType;
                    transactiondto.Amount = transactions.Amount;
                    transactiondto.AccountID=transactions.AccountID;
                    result.Add(transactiondto);
                }

                return result;
            });

            return r;
        }
    }
}
