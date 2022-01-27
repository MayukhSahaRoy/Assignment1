using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog10
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 5; i < n; i++)
                s = s + (i * i * i);
            Console.WriteLine("The required sum is " + s);
            Console.ReadKey();
        }
    }
}
