using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog6
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature in farenheit: ");
            double f = Double.Parse(Console.ReadLine());
            double c = ((f - 32) * 5) / 9;
            Console.WriteLine("The temperature in celsius degree is: "+c);
            Console.ReadKey();
        }
    }
}
