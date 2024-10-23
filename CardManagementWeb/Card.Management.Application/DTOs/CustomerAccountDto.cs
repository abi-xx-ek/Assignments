using Card.Management.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.DTOs
{
    public class CustomerAccountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<AccountDto> Account { get; set; }
        
        
    }
}
