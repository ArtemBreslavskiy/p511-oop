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
            Rectangle rect1 = new Rectangle(8, 4.9);
            Rectangle rect2 = new Rectangle(10, 100);
            Rectangle rect3 = new Rectangle(5.313213, 7.8);

            double width1 = rect1.width;
            double height1 = rect1.height;

            double width2 = rect2.width;
            double height2 = rect2.height;

            double width3 = rect3.width;
            double height3 = rect3.height;

            Console.WriteLine($"Ширина: {width1}, Высота: {height1}, Площадь: {rect1.GetArea()}, Периметр: {rect1.GetPerimeter()}");
            Console.WriteLine($"Ширина: {width2}, Высота: {height2}, Площадь: {rect2.GetArea()}, Периметр: {rect2.GetPerimeter()}");
            Console.WriteLine($"Ширина: {width3}, Высота: {height3}, Площадь: {rect3.GetArea()}, Периметр: {rect3.GetPerimeter()}");
        }

        class Rectangle
        {
            public double width;
            public double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double GetArea() { return width * height; }

            public double GetPerimeter() { return (width + height) * 2; }
        }
    }
}
