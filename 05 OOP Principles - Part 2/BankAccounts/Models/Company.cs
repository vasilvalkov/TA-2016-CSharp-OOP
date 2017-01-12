namespace BankAccounts.Models
{
    using Interfaces;

    public class Company : ICustomer
    {
        private string fullName;

        public Company (string name)
        {
            this.FullName = name;
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                this.fullName = value.ToUpper();
            }
        }
    }
}