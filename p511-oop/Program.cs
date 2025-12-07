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
            List<Pasport> pasports = new List<Pasport>();

            pasports.Add(new Pasport("Bob", "Doe", 1, 1));
            pasports.Add(new Pasport("Tom", "Doe", 2, 2));
            pasports.Add(new Pasport("John", "Doe", 3, 3));
            pasports.Add(new Pasport("Tim", "Doe", 4, 4));

            foreach (Pasport pasport in pasports)
            {
                pasport.PrintData();
                Console.WriteLine();
            }
        }
    }
}
