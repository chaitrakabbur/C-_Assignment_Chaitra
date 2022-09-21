using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MinMaxNum
    {
        public static void Main()
        {
            int n;

            Console.WriteLine("Enter the array number: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Enter the array values");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Maximum number is {numbers.Max()} ");
            Console.WriteLine($"Minimum number is {numbers.Min()} ");
        }
    }
}
