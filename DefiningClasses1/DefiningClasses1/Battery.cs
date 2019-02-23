using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    public class Battery
    {
        public string model;
        public uint hoursIdle;
        public uint hoursTalk;
        public BatteryType batteryType;
        

        public Battery(string Model, uint HoursIdle, uint HoursTalk, BatteryType BatteryType)
        {
            this.model = Model;
            this.hoursIdle = HoursIdle;
            this.hoursTalk = HoursTalk;
            this.batteryType = BatteryType;
        }

        public string Model
        { get; set; }

        public uint HoursIdle
        { get; set; }

        public uint HoursTalk
        { get; set; }
        
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
             set
            {
                this.batteryType = value;
            }
        }

    }
}
