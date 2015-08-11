using System;

namespace DefiningClassesPart1
{
    // Problem 1
    public class Battery
    {
        private string model;
        private int idleHours;
        private int talkHours;
        private BatteryTypes batteryType; // Problem 3

        // Problem 5
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0 || value.Length > 26)
                {
                    throw new ArgumentOutOfRangeException("Model name cannot be zero symbols or longer than 10 symbols.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public BatteryTypes BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public int IdleHours
        {
            get { return this.idleHours; }
            private set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Idle hours should be between zero and 1000 inclusive.");
                }
                else
                {
                    this.idleHours = value;
                }
            }
        }

        public int TalkHours
        {
            get { return this.talkHours; }
            private set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Talk hours should be between zero and 24 inclusive.");
                }
                else
                {
                    this.talkHours = value;
                }
            }
        }
        // Problem 2
        public Battery() : this("Standard", 200, 15, BatteryTypes.NiCD) { }

        public Battery(string model) : this(model, 300, 20, BatteryTypes.LiIon) { }

        public Battery(string model, int hoursIdle, int hoursTalk,BatteryTypes batteryType)
        {
            this.Model = model;
            this.IdleHours = hoursIdle;
            this.TalkHours = hoursTalk;
            this.BatteryType = batteryType;
        }
        // Problem 4
        public override string ToString()
        {
            return String.Format(" Model: {0}\n Hours idle: {1} hours\n Talktime: {2} hours\n Battery type: {3}",
                                  Model, IdleHours, TalkHours, BatteryType);
        }
    }
}