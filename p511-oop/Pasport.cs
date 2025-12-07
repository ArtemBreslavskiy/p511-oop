using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Pasport
    {
        protected string firstName;
        protected string lastName;
        protected int pasportSeries;
        protected int pasportNumber;
        
        public Pasport(string firstName, string lastName, int pasportSeries, int pasportNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pasportSeries = pasportSeries;
            this.pasportNumber = pasportNumber;
        }

        public virtual void PrintData()
        {
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Серия паспорта: {pasportSeries}");
            Console.WriteLine($"Номер паспорта: {pasportNumber}");
        }
    }
}
