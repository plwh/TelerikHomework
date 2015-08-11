// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void myDelegate();

    class Timer
    {
        private int interval;

        public Timer(int interval)
        {
            this.interval = interval;
        }

        public int Interval
        {
            set { this.interval = value; }
        }

        public string ExecuteMethod(myDelegate currDelegate)
        {
            while (true)
            {
                currDelegate();
                Thread.Sleep(interval*2000);
            }
        }
    }
}
