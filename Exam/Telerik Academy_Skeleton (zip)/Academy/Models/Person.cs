using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public abstract class Person
    {
        private const byte MIN_USERNAME_LENGTH = 3;
        private const byte MAX_USERNAME_LENGTH = 16;
        private string userName;

        public Person(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get
            {
                return this.userName;
            }

            set
            {
                if (value.Length < MIN_USERNAME_LENGTH || value.Length > MAX_USERNAME_LENGTH)
                {
                    throw new ArgumentException(string.Format("User's username should be between {0} and {1} symbols long!", MIN_USERNAME_LENGTH, MAX_USERNAME_LENGTH));
                }

                this.userName = value;
            }
        }

    }
}
