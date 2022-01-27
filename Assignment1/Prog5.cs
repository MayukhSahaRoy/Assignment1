using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog5
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of times you want to input:");
            int n = int.Parse(Console.ReadLine());
            int even = 0, odd = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter a number:");
                int item = int.Parse(Console.ReadLine());
                if (item % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("the number of even numbers entered by the user is: " + even);
            Console.WriteLine("the number of odd numbers entered by the user is: " + odd);
            Console.ReadKey();
        }
    }
}
