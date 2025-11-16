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
            Rectangle rect1 = new Rectangle(3, 4.5);

            Console.WriteLine($"Ширина: {rect1.Width}");
            Console.WriteLine($"Высота: {rect1.Height}");
            Console.WriteLine($"Площадь: {rect1.Area}");
            Console.WriteLine($"Периметр: {rect1.Perimeter}");
        }

        class Rectangle
        {
            private double _width;
            private double _height;

            public double Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    if (value > 0)
                    {
                        _width = value;
                    }
                }
            }

            public double Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    if (value > 0)
                    {
                        _height = value;
                    }
                }
            }

            public double Area
            {
                get
                {
                    return _width * _height;
                }
            }

            public double Perimeter
            {
                get
                {
                    return (_width + _height) * 2;
                }
            }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }
    }
}
