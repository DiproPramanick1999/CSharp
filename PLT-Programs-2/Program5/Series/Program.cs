using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  1, 4, 7, 12, 23, 42, 77, … N

            int num;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            int a = 1, b = 4, c = 7, d;
            Console.Write(1 + " " + 4 + " " + 7 + " ");
            for (int i = 0; i < num; i++)
            {
                d = a + b + c;
                Console.Write(d + " ");
                a = b;
                b = c;
                c = d;
            }
            Console.ReadLine();

            //uncomment the below code to get the following output
            //2.  1, 4, 9, 25, 36, 49, 81, 100, … N

            //int num,count=0;
            //Console.Write("Enter number: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    if (count == 3)
            //    {
            //        count = 0;
            //        continue;
            //    }
            //    else
            //    Console.Write(Math.Pow(i + 1, 2)+" ");
            //    count += 1;
            //}
            //Console.ReadLine();

            //uncomment the below code to get the following output
            //3.  1, 5, 13, 29, 49, 77, … N

            //int num;
            //Console.Write("Enter number: ");
            //num = int.Parse(Console.ReadLine());
            //Console.Write(1+" ");
            //int a = 1,b,count=0;
            //for (int i = 1; i < num; i++)
            //{
            //    if (count == 2)
            //    {
            //        count = 0;
            //        continue;
            //    }
            //    else
            //    {
            //        b = a + 4 * i;
            //        Console.Write(b+" ");
            //        a = b;
            //        count += 1;
            //    }
            //}
            //Console.ReadLine();

        }
    }
}
