using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.a    *
            //      **
            //     ***
            //    ****
            //        :    
            //  N rows

            int a, b = 1;
            Console.Write("Enter the range N: ");
            a = int.Parse(Console.ReadLine());
            for (int i = a; i >= 1; i--)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= b; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                b++;
            }
            Console.ReadLine();

            //4.b  *
            //    ***
            //   *****
            //  *******
            //  ..N


            //int a, b = 1;
            //Console.Write("Enter the range N: ");
            //a = int.Parse(Console.ReadLine());
            //for (int i = a; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= b; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //    mb++;
            //}
            //Console.ReadLine();


        }
    }
}
