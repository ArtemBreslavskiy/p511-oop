using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void PrintPosition()
        {
            Console.WriteLine($"\tx: {X}\n");
            Console.WriteLine($"\ty: {Y}\n");
            Console.WriteLine($"\tz: {Z}");
        }
    }
}
