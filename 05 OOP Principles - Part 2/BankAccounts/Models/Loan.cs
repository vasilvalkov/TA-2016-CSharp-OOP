namespace BankAccounts.Models
{
    using Interfaces;

    public class Loan : Account
    {
        private const byte MONTHS_WITH_NO_INTEREST_FOR_COMPANY = 2;
        private const byte MONTHS_WITH_NO_INTEREST_FOR_INDIVIDUAL = 3;

        public Loan(ICustomer customer, decimal interestPerMonth, ushort termInMonths, decimal amount)
            : base(customer, interestPerMonth, termInMonths)
        {
            this.balance = amount > 0 ? amount * (-1) : amount;
        }

        public override decimal InterestPerMonth
        {
            get
            {
                return this.interestPerMonth;
            }
            protected set
            {
                this.interestPerMonth = value;
            }
        }

        public override decimal CalculateInterestAmount(int months)
        {
            return (this.Customer.GetType().Name == "Company"
                        ? base.CalculateInterestAmount(this.TermInMonths - MONTHS_WITH_NO_INTEREST_FOR_COMPANY)
                        : base.CalculateInterestAmount(this.TermInMonths - MONTHS_WITH_NO_INTEREST_FOR_INDIVIDUAL));
        }
    }
}