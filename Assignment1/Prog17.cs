using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog17
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string str = Console.ReadLine();
            int len = str.Length;
            string str2 = "";
            for(int i=len-1; i>=0;i--)
            {
                char temp = str[i];
                str2 = str2 + temp;
            }
            Console.WriteLine("The reverse of the given word is: " + str2);
            Console.ReadKey();
        }
    }
}
