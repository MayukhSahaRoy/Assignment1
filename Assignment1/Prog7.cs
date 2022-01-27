using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog7
    {
        static void Main()
        {
            Console.WriteLine("The required series is \n");
            for(int i = 0; i <= 25; i++)
            {
                int s = i * i;
                Console.Write(s + " ");
            }
            Console.ReadKey();
        }
    }
}
