using System;

namespace Euclids
{
    class Program
    {
        public static int GCD(int a,int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for a and b: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GCD of " + a + " and " + b + " is: " + GCD(a, b));
        }
    }
}
