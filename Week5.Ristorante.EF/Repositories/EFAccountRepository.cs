﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week5.Ristorante.Core.Interfaces;
using Week5.Ristorante.Core.Models;

namespace Week5.Ristorante.EF.Repositories
{
    public class EFAccountRepository : IAccountRepository
    {
        private readonly PiattoContext ctx;
        public EFAccountRepository(PiattoContext context)
        {
            this.ctx = context;
        }
        public bool AddItem(Account newItem)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(Account itemToEdit)
        {
            throw new NotImplementedException();
        }

        public List<Account> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetByUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            try
            {
                return ctx.Accounts.FirstOrDefault(x => x.Username.Equals(username));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
