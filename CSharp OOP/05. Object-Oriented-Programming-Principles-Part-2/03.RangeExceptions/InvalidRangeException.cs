
namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T startOfRange;
        private T endOfRange;

        public InvalidRangeException(string message, T start, T end)
            : this(message, null, start, end)
        {
 
        }

        public InvalidRangeException(string message,Exception innerException, T start, T end)
            : base(message, innerException)
        {
            this.StartOfRange = start;
            this.EndOfRange = end;
        }

        public T StartOfRange
        {
            get { return this.startOfRange; }
            set { this.startOfRange = value; }
        }

        public T EndOfRange
        {
            get { return this.endOfRange; }
            set { this.endOfRange = value; }
        }
    }
}
