using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Plane
    {
        private string planeName;
        private string planeType;
        private string brand;

        private DateTime yearOfCreating {  get; set; }
        public string PlaneName
        {
            get { return planeName; }
            set { if (value == "") planeName = value; }
        }
        public string PlaneType
        {
            get { return planeType; }
            set { if (value == "") planeType = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { if (value == "") brand = value; }
        }

        public Plane(
            string planeName = "Unknown",
            string planeType = "Unknown",
            string brand = "Unknown",
            DateTime yearOfCreating = default
            )
        {
            this.planeName = planeName;
            this.planeType = planeType;
            this.brand = brand;
            this.yearOfCreating = yearOfCreating;
        }

        public void PrintEmployerData()
        {
            Console.WriteLine($"\n\tНазвание: {planeName}\n");
            Console.WriteLine($"\tТип самолёта: {planeType}\n");
            Console.WriteLine($"\tБренд: {brand}\n");
            Console.WriteLine($"\tДата производства: {yearOfCreating}\n");
        }

        public void InputNewYearOfCreating()
        {
            Console.Write("Введите новое имя:");
            yearOfCreating = Convert.ToDateTime(Console.ReadLine());
        }

        public void InputNewPlaneName()
        {
            Console.Write("Введите новое имя:");
            PlaneName = Console.ReadLine();
        }

        public void InputNewPlaneType()
        {
            Console.Write("Введите новое имя:");
            PlaneType = Console.ReadLine();
        }

        public void InputNewBrand()
        {
            Console.Write("Введите новое имя:");
            Brand = Console.ReadLine();
        }
    }
}
