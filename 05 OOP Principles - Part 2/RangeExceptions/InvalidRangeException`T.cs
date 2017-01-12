namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg, T rangeFrom, T rangeTo)
            : base(msg)
        {
            this.From = rangeFrom;
            this.To = rangeTo;
        }

        public T From { get; set; }
        public T To { get; set; }

        public override string Message
        {
            get
            {
                return string.Format("{0} [{1} - {2}]", base.Message, From, To);
            }
        }
    }
}