using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog19
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string str = Console.ReadLine();
            int flag = 0;
            int len = str.Length;
            for(int i = 0; i < len; i++)
            {
                if (str[i] != str[len - i - 1])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(str + " is a palindrome");
            else
                Console.WriteLine(str + " is not a palindrome");
            Console.ReadKey();
        }
    }
}
