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
            int[,] e =
            {
                {1, 2 },
                {3, 4 },
            };

            Matrix m = new Matrix(e);
            m.PrintMatrix();
        }
    }
}
