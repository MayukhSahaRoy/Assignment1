using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog9
    {
        static void Main()
        {
            Console.WriteLine("The fibinacci series is as follows: ");
            int a = 0, b = 1, s = 0;
            Console.Write(a + " " + b);
            for(; ; )
            {
                s = a + b;
                if (s > 40)
                    break;
                Console.Write(" " + s);
                a = b;
                b = s;
            }
            Console.ReadLine();
        }
    }
}
