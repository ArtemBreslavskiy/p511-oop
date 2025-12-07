using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Vehicle
    {
        protected double averageSpeed;
        protected double costPerKM;
        protected int passengerCapacity;
        protected double cargoCapacity;

        protected Vehicle(double averageSpeed, double costPerKM, int passengerCapacity, double cargoCapacity)
        {
            this.averageSpeed = averageSpeed;
            this.costPerKM = costPerKM;
            this.passengerCapacity = passengerCapacity;
            this.cargoCapacity = cargoCapacity;
        }

        public abstract double CalculateTime(double distance);
        public abstract double CalculatePrice(double distance, int passengersCount, double cargo);
    }
}
