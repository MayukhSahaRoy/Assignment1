using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog16
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("Length of the word is:" + len);
            Console.ReadKey();
        }
    }
}
