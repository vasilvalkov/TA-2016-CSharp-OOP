namespace App.Models
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private byte age;
        private string facultyNumber;
        private uint? phoneNumber;
        private ushort groupNumber;
        private string email;
        private List<Mark> marks;

        public Student(string firstName, string lastName, byte age, string facultyNumber, ushort groupNumber)
            : this(firstName, lastName, age, facultyNumber, null, groupNumber, string.Empty, new List<Mark>())
        {
        }
        public Student(string firstName, string lastName, byte age, string facultyNumber, uint? phoneNumber, ushort groupNumber, string email, List<Mark> marks)
        {
            this.FirstName = firstName;
            this.LasttName = lastName;
            this.Age = age;
            this.FN = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.GroupNumber = groupNumber;
            this.Email = email;
            this.marks = marks;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("The first name cannot be empty");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The first name must be at least two symbols");
                }

                this.firstName = value;
            }
        }
        public string LasttName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("The last name cannot be empty");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The last name must be at least two symbols");
                }

                this.lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return this.firstName + ' ' + this.lastName;
            }
        }
        public byte Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public string FN
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("The faculty number cannot be empty");
                }
                else if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("The faculty number must be at least five symbols");
                }

                this.facultyNumber = value;
            }
        }
        public uint? PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public ushort GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value.ToString().Length == 0)
                {
                    throw new ArgumentOutOfRangeException("The group number cannot be empty");
                }

                this.groupNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public List<Mark> Marks
        {
            get
            {
                return this.marks;
            }
        }

        public void AddMark(Mark mark)
        {
            this.marks.Add(mark);
        }
        public override string ToString()
        {
            return this.FullName;
        }
    }
}