using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingStop.Vehicles_Classes
{
    public class Car : Vehicle, IAutomobile
    {
        
        public Car(String tag,
                   String type, 
                   String model,
                   String timeIn,
                   String duration,
                   String payment)
        {
            Tag = tag;
            Type = type;
            Model = model;
            TimeIn = timeIn;
            Duration = duration;
            Payment = payment;
        }
    }
}
