using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog8
    {
        static void Main()
        {
            Console.WriteLine("Enter a number :");
            int n = int.Parse(Console.ReadLine());
            int f = 1;
            for(int i=1;i<=n;i++)
                f=f*i;
            Console.WriteLine("The factorial of the number is :" + f);
            Console.ReadKey();



































































        }
    }
}
