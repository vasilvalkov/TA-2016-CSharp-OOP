namespace SchoolClasses
{
    class Student : Person, IStudent, IComment
    {
        private byte classNumber;

        public Student(string name, byte classNumber) 
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public byte ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }

        public string Comment(string text)
        {
            return string.Format($"The student {this.Name} comments: {text}");
        }
    }
}