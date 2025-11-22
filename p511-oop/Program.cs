using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 3, 10, 9, 3 };
            int[] arr3 = { 2, 7 };

            PrintArray(ArraysSum(arr1, arr3));
        }

        static int[] ArraysSum(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Неверная длинна массивов. Длинна массивов должна быть одинаковой.");
            }

            int[] result = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"{i + 1}: {arr[i]}");
        }
    }
}
