namespace BankAccounts.Models
{
    using System;
    using Interfaces;

    public class Deposit : Account, IDeposit
    {
        public Deposit(ICustomer customer, decimal interestPerMonth, byte termInMonths)
            : base(customer, interestPerMonth, termInMonths)
        {
        }
        public Deposit(ICustomer customer, decimal interestPerMonth, byte termInMonths, decimal amount)
            : this(customer, interestPerMonth, termInMonths)
        {
            if (amount <= 0m)
            {
                throw new ArgumentException("You must deposit a positive amount!");
            }
            else
            {
                this.balance = amount;
            }
        }

        public override decimal InterestPerMonth
        {
            get
            {
                if (this.balance > 0 && this.balance < 1000)
                {
                    return 0m;
                }
                else
                {
                    return this.interestPerMonth; 
                }
            }
            protected set
            {
                this.interestPerMonth = value;
            }
        }
        
        public void WithdrawAmount(decimal amount)
        {
            this.balance -= amount;
        }
        public override decimal CalculateInterestAmount(int months)
        {
            return base.CalculateInterestAmount(months);
        }
    }
}