using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num = 0;
            int fact = 1;
            string input = Console.ReadLine(); // Input
            num = Convert.ToInt32(num); // Convert string to normal int 

            for (int i = 2; i <= num; i++)
                fact *= i; // n! = n * (n-1)! 

            Console.Write("Fact = "); // Output without Enter(\n)
            Console.WriteLine(fact); // Output with Enter(\n)

            Console.ReadLine(); // To prevent console closure
        }
    }
}
