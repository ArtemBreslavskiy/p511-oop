using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Bike : Vehicle
    {
        public Bike(double averageSpeed,
            double costPerKM,
            int passengerCapacity,
            double cargoCapacity) : base(averageSpeed, costPerKM, passengerCapacity, cargoCapacity) { }

        public override double CalculatePrice(double distance, int passengersCount, double cargo)
        {
            if (passengersCount <= passengerCapacity) return costPerKM * distance + (passengersCount * 20) + (cargo * 500);
            else throw new Exception($"Неверное значение пассажиров. Максимально колличество пассажиров {passengerCapacity}");
        }

        public override double CalculateTime(double distance)
        {
            return averageSpeed * distance;
        }
    }
}

