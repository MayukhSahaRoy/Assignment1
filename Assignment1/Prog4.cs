using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog4
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number");
            else
                Console.WriteLine(n + " is an odd number");
            Console.ReadKey();
        }
    }
}
