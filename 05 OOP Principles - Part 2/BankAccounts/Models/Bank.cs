namespace BankAccounts.Models
{
    using Interfaces;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Bank
    {
        private ICollection<Account> accounts;

        public Bank()
            : this (new HashSet<Account>())
        {
        }
        public Bank(ICollection<Account> accounts)
        {
            this.accounts = new HashSet<Account>(accounts);
        }

        public ICollection<ICustomer> Customers
        {
            get
            {
                return new List<Account>(this.accounts).Select(x => x.Customer).ToList();
            }
        }
        public ICollection<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
        }

        public void AddAccount(Account account)
        {
            ChackIfExists(this.Accounts, account);
            this.accounts.Add(account);
        }
        
        private void ChackIfExists(ICollection<Account> collection, Account account)
        {
            try
            {
                if (collection.Contains(account))
                {
                    throw new ArgumentException($"The {account.GetType().Name.ToLower()} already exists!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}