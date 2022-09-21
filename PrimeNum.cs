using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PrimeNum
    {
        public static bool PrimeCheck(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (PrimeCheck(n))
                Console.WriteLine(n + " is prime number");
            else
                Console.WriteLine(n + " is not prime number");
        }
    }
}
