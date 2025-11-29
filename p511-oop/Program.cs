using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "+7 123 456 78 90", "Boston", "USA", "Boston University", "Boston", "USA", "g109", new DateTime(2003, 3, 12));
            student.PrintValue();

            Console.WriteLine();
            Console.WriteLine();

            Point point = new Point(15.89, 4.36, 58.04);
            point.PrintPosition();
        }
    }
}

