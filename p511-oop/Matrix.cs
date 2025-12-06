using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Matrix
    {
        private int[,] values;

        public int XLength { get; private set; }
        public int YLength { get; private set; }

        public Matrix(int[,] values)
        {
            CopyArray(values);
        }

        public void CopyArray(int[,] values)
        {
            this.values = new int[values.GetLength(0), values.GetLength(1)];
            XLength = values.GetLength(0);
            YLength = values.GetLength(1);

            for (int i = 0; i < XLength; i++)
                for (int j = 0; j < YLength; j++)
                    this.values[i, j] = values[i, j];
        }

        public void ChangeMatrixElement(int newValue, int XIndex, int YIndex)
        {
            values[XIndex, YIndex] = newValue;
        }

        public void PrintMatrix()
        {
            Console.Write("   ");
            for (int i = 0; i < YLength; i++)
                Console.Write($"\t{i}:");
            Console.WriteLine();

            for (int i = 0; i < XLength; i++)
            {
                Console.Write($"{i}: ");

                for (int j = 0; j < YLength; j++)
                {
                    Console.Write($"\t{values[i, j]}");
                }

                Console.WriteLine();
            }
        }
    }
}
