using System;

namespace DefineClasses
{
    class Call
    {   // fields
        private DateTime date;
        private TimeSpan time;
        private string dialedNumber;
        private double duration;
        // constructors
        public Call(string number, double seconds)
        {
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now.TimeOfDay;
            this.DialedNumber = number;
            this.Duration = seconds;
        }
        // properties
        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }
        public TimeSpan Time
        {
            get { return this.time; }
            private set { this.time = value; }
        }
        public string DialedNumber
        {
            get { return this.dialedNumber; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Phone number cannot be empty");
                }

                foreach (var symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        throw new FormatException("The phone number must conatain only digits");
                    }
                }

                this.dialedNumber = value;
            }
        }
        public double Duration
        {
            get { return this.duration; }
            private set { this.duration = TimeSpan.FromSeconds(value).TotalSeconds; }
        }
    }
}