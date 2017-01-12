namespace BankAccounts.Models
{
    using Interfaces;
    using System.Text;

    public abstract class Account
    {
        private readonly ICustomer customer;
        protected decimal balance;
        protected decimal interestPerMonth;
        private ushort termInMonths;

        protected Account (ICustomer customer, decimal interestPerMonth, ushort termInMonths)
        {
            this.Customer = customer;
            this.InterestPerMonth = interestPerMonth;
            this.TermInMonths = termInMonths;
        }

        public ICustomer Customer { get; }
        public ushort TermInMonths
        {
            get
            {
                return this.termInMonths;
            }
            private set
            {
                this.termInMonths = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }
        public abstract decimal InterestPerMonth { get; protected set; }

        public virtual decimal CalculateInterestAmount(int months)
        {
            return this.InterestPerMonth * months * (this.balance / 100);
        }
        public void DepositAmount(decimal amount)
        {
            this.balance += balance;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"--- {this.GetType().Name} account owned by the {this.Customer.GetType().Name.ToLower()} {this.Customer.FullName} ---");
            text.AppendLine($"Balance: {this.Balance:C2}");
            text.AppendLine($"Term: {this.TermInMonths} months");
            text.AppendLine($"Interest rate: {this.InterestPerMonth:C4} per month");
            text.AppendLine($"Interest for the whole term: {this.CalculateInterestAmount(this.TermInMonths):C2}");

            return text.ToString();
        }
    }
}