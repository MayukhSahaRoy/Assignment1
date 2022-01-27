using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog14
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers:");
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
                a[i] = int.Parse(Console.ReadLine());
            int min = a[0];
            for(int i = 0; i < 5; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("The smallest number is " + min);
            Console.ReadKey();
        }
    }
}
