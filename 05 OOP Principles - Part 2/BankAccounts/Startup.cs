﻿namespace BankAccounts
{
    using Models;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {   // Create accounts
            ICollection<Account> accounts = new HashSet<Account>
            {
                new Deposit(new Individual("Pesho Petrov Toshov"), 0.0208m, 18, 2500m),
                new Loan(new Individual("Uzun Ouzunov Uzonov"), 0.2m, 18, 900m),
                new Mortgage(new Individual("Mariyka Tupalkova yakakakova"), 0.14m, 18, 50000m),
                new Deposit(new Company("Studena Voda OOD"), 0.026m, 24, 25000m)
            };
            // Create bank
            Bank bank = new Bank(accounts);
            // Deposit money
            bank.Accounts
                    .Where(account => account.Customer.FullName == "Uzun Ouzunov Uzonov".ToUpper())
                    .First()
                    .DepositAmount(100m);
            // Withdraw money from deposit
            bank.Accounts
                    .Where(account => account.GetType().Name == "Deposit" && 
                                      account.Customer.FullName == "Studena Voda OOD".ToUpper())
                    .Cast<Deposit>()
                    .First()
                    .WithdrawAmount(4000);
            // Add account
            bank.AddAccount(new Loan(new Company("ET Cveten Uzhast"), 0.254m, 36, 9000m));
            
            foreach (var account in bank.Accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}