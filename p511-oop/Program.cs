using System;
using System.Collections.Generic;
using System.Deployment.Internal;
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
            
        }

        static double Mv(double[,] m, double[] v)
        {
            double[] answer = new double[m.GetLength(1)];
            return - 1;
        }

        static int Activation(double x)
        {
            if (x > 0.5) return 1;
            else return 0;
        }

        static int Go(int sun, int rain, int cold)
        {
            int[] X = new int[] { sun, rain, cold};
            double[,] Wh = new double[,] { { 0.3, 0.3, 0 }, { -0.3, 0.2, 0.5 } };
            double[] Wout = new double[] { 1, -1 };

            return -1;
        }
    }
}
