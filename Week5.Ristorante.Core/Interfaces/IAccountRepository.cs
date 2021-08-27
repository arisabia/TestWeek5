using System;
using System.Collections.Generic;
using System.Text;
using Week5.Ristorante.Core.Models;

namespace Week5.Ristorante.Core.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByUsername(string username);
    }
}
