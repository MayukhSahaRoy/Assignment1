using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog3
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers between " + m + " and " + n + " are as follows\n");
            if (m < n)
            {
                for (int i = m + 1; i < n; i++)
                    Console.WriteLine(i + " ");
            }
            else
            {
                for (int i = n + 1; i < m; i++)
                    Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
    }
}
