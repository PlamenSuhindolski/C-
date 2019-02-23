using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display(5.5, 1000000);
            Battery battery = new Battery("Toshiba", 20,10, BatteryType.NiCd);
            Phone phone = new Phone("Honor 8","HUawei", display, battery, 550);
            
            phone.ToString();
            phone.Battery.BatteryType = BatteryType.LiIon;
            //Console.WriteLine(Phone.Iphone4s);
            Console.WriteLine(phone.battery.BatteryType);
            
        }
    }
}
