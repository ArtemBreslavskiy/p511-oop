using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class InternationalPasport : Pasport
    {
        List<String> visas = new List<string>();

        public InternationalPasport(string firstName,
            string lastName,
            int pasportSeries,
            int pasportNumber,
            List<String> visas) : base(firstName, lastName, pasportSeries, pasportNumber) {

            this.visas = visas;
        }

        public override void PrintData()
        {
            base.PrintData();

            Console.Write("Визы: ");
            foreach (var visa in visas) Console.Write($"{visa}, ");

        }
    }
}
