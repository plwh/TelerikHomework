using System;

namespace DefiningClassesPart1
{
    // Problem 8
    public class Call
    {     
        private DateTime date;

        private string dialedPhoneNumber; 
        private int duration;

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Call(DateTime date, string dialedNumber, int duration)
        {
            this.Date = date;
            this.DialedPhoneNumber = dialedNumber;
            this.Duration = duration;
        }
        // Problem 4
        public override string ToString()
        {
            return String.Format("Date and time:{0}\n Dialed number: {1}\n Duration: {2} seconds",
                                  Date,DialedPhoneNumber,Duration);
        }
    }
}
