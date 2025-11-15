using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    class User
    {
        public string Name;
        public string Surname;
        public int Age;
        public string City;

        public User(string name, string surname, int age, string city)
        {
            Name = name;
            Surname = surname;
            Age = age;
            City = city;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, City: {City}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Bob", "Eagan", 32, "New York");

            user.Print();
        }
    }
}
