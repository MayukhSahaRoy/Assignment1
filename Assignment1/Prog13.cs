using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog13
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(c);
            }
            else
            {
                if (b > c)
                    Console.WriteLine(b);
                else
                    Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
