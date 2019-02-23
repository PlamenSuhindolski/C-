using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    public class Phone
    {
        public string model;
        public string manufacturer;
        public uint price;
        public string owner;
        public Display display;
        public Battery battery;
        public readonly static Phone Iphone4s = new Phone("Iphone 4S","Apple",new Display(5.5, 256000), new Battery("Toshiba",20,15,BatteryType.NiCd), 800);
        private List<Call> callHistory;
        public const double fixedPhoneCallPrice = 0.37;

        public Phone(string Model, string manifacturer)
        {
            this.model = Model;
            this.manufacturer = manifacturer;
        }

        public Phone(string Model, string Manifacturer, Display Display, Battery Battery, uint Price)
        {
            this.model = Model;
            this.manufacturer = Manifacturer;
            this.display = Display;
            this.battery = Battery;
            this.price = Price;
        }

        public Phone(string Model, string Manifacturer, Display Display, Battery Battery, string Owner)
        {
            this.model = Model;
            this.manufacturer = Manifacturer;
            this.display = Display;
            this.battery = Battery;
            this.owner = Owner;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public uint Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The owner`s name should be at least 2 letters");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
             set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory    
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

    

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
             result.AppendLine(this.model);
             result.AppendLine(this.manufacturer);
            result.AppendLine(this.owner);
            result.AppendLine(this.price.ToString());
            result.AppendLine(this.battery.model);
            result.AppendLine(this.battery.BatteryType.ToString());
            result.AppendLine(this.battery.hoursIdle.ToString());
            result.AppendLine(this.battery.hoursTalk.ToString());
            result.AppendLine(this.display.size.ToString());
            result.AppendLine(this.display.numberOfColors.ToString());
            Console.WriteLine(result);
            return base.ToString();
        }

        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> RemoveCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;

        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            double totalDuration = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].duration;
            }
            totalPrice = totalDuration * fixedPhoneCallPrice;

            return totalPrice;
        }
    }
}
