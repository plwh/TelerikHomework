using System;
using System.Collections.Generic;

namespace DefiningClassesPart1
{
    // Problem 1
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> calls;
        // Problem 6
        private static GSM iPhone = new GSM("IPhone4S", "Apple Inc.", 1000, "Gosho", new Battery("iPhone battery"), new Display(3.5, 16000000), new List<Call>());

        public static GSM IPhone4S
        {
            get { return iPhone; }
            set { iPhone = value; }
        }
        // Problem 5
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Model name cannot be zero symbols or longer than 10 symbols.");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (value.Length == 0 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer name cannot be zero symbols or longer than 10 symbols.");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            private set 
            {
                if (value < 0 || value > 3000)
                {
                    throw new ArgumentOutOfRangeException("Price should be between 0 and 3000 inclusive.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value.Length == 0 || value.Length > 25)
                {
                    throw new ArgumentOutOfRangeException("Owner name cannot be zero symbols or longer than 25 symbols.");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        // Problem 2
        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.0, "John", new Battery("Generic", 0, 0, BatteryTypes.NiMH), new Display(0.0, 4096), new List<Call>()) { }

        public GSM(string model, string manufacturer, double price, string owner,Battery battery, Display display,List<Call> calls)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.CallHistory = new List<Call>();
        }
        // Problem 9
        public List<Call> CallHistory
        {
            get { return this.calls; }
            set{ this.calls = value; }
        }
        // Problem 10
        public List<Call> AddCall(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }
        // Problem 11
        public decimal CalculateTotalPrice(decimal price)
        { 
            decimal durationOfAllCalls = 0;
            decimal totalPriceOfCalls = 0;
            for(int i=0;i<CallHistory.Count;i++)
            {
                durationOfAllCalls += CallHistory[i].Duration/60.0m;
            }
            totalPriceOfCalls = durationOfAllCalls * price;
            return totalPriceOfCalls;
        }
        // Problem 4
        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\nModel: {1}\nPrice: {2} lv\nOwner: {3}\nBattery info:\n{4}\nDisplay info:\n{5}",
                                  Manufacturer, Model, Price, Owner, battery, display);
        }

    }
}

