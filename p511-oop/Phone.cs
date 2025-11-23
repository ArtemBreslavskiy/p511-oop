using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Phone
    {
        private string brand;
        private string model;
        private decimal price;

        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            private set
            {
                if (value <= 0)
                {
                    price = value;
                }
            }
        }

        public Phone(string brand = "Unknown", string model = "Unknown", decimal price = -1)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nBrand: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
