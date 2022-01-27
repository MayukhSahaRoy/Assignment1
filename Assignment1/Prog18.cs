using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog18
    {
        static void Main()
        {
            Console.WriteLine("Enter two Strings:");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            if (String.Equals(s1, s2))
                Console.WriteLine("They both are same");
            else
                Console.WriteLine("They are not same");
            Console.ReadKey();
        }
    }
}
