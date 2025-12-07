using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car(80, 20, 5, 4));
            vehicles.Add(new Bike(20, 5, 2, 1));
            vehicles.Add(new Cart(12, 10, 4, 2));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Время: {vehicle.CalculateTime(15)}");
                Console.WriteLine($"Стоимость: {vehicle.CalculatePrice(15, 2, 1)}");
            }
        }
    }
}
