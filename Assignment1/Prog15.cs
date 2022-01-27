using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Prog15
    {
        static void Main()
        {
            Console.WriteLine("Enter 10 marks:");
            double[] a = new double[10];
            double total = 0, max = 0,temp;
            for (int i = 0; i < 10; i++)
                a[i] = double.Parse(Console.ReadLine());
            double min = a[0];
            for(int i = 0; i < 10; i++)
            {
                total = total + a[i];
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            double avg = total / 10;
            for(int i = 0; i < 9; i++)
            {
                int m = i;
                for(int j = i + 1; j < 10; j++)
                {
                    if (a[j] < a[m])
                        m = j;
                    temp = a[m];
                    a[m] = a[i];
                    a[i] = temp;
                }
            }
            Console.WriteLine("The total marks is: " + total);
            Console.WriteLine("The average marks is: " + avg);
            Console.WriteLine("The maximum marks is: " + max);
            Console.WriteLine("The minimum marks is: " + min);
            Console.WriteLine("The marks in ascending order is as follows:");
            for (int i = 0; i < 10; i++)
                Console.Write(" " + a[i]);
            Console.WriteLine("The marks in descending order is as follows:");
            for (int i = 9; i >= 0; i--)
                Console.Write(" " + a[i]);
            Console.ReadKey();
        }
    }
}
