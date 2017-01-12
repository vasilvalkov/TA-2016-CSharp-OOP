namespace BankAccounts.Models
{
    using Interfaces;
    using System;
    using System.Linq;

    public class Individual : ICustomer
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public Individual(string fullName)
        {
            this.FullName = fullName;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + middleName + " " + this.lastName;
            }
            private set
            {
                var temp = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x.Trim().ToUpper())
                                .ToArray();
                if (temp.Length < 3)
                {
                    throw new ArgumentException("The name is not full!");
                }

                this.firstName = temp[0];
                this.middleName = temp[1];
                this.lastName = temp[2];
            }
        }
    }
}
