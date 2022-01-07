using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. 1, 2, 6, 15, 31, 56 … N
            int num;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("1 ");
            int a = 1, b;
            for (int i = 1; i < num; i++)
            {
                b = a + (i * i);
                Console.Write(b + " ");
                a = b;
            }
            Console.ReadLine();

            //uncomment the below code to get the following output
            //b. 1, 1, 2, 3, 5, 8, 13, … N
            //int num;
            //Console.Write("Enter the number: ");
            //num = int.Parse(Console.ReadLine());
            //Console.Write("1 1 ");
            //int a = 1, b=1,c;
            //for (int i = 2; i < num; i++)
            //{
            //    c = a + b;
            //    Console.Write(c+" ");
            //    a = b;
            //    b = c;
            //}
            //Console.ReadLine();



        }
    }
}
