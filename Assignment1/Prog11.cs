using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog11
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int s;
            Console.WriteLine("The multiplication table of " + n + " is as follows:");
            for(int i = 1; i <= 20; i++)
            {
                s = n * i;
                Console.WriteLine(n + " * " + i + " = " + s);
            }
            Console.ReadKey();
        }
    }
}
