using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 11111    
            //   22222
            //   33333
            //   44444
            //   N rows

            int num;
            Console.Write("Enter the N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //2. *****
            //   *****
            //   *****
            //   *****
            //   N rows
            //int num;
            //Console.Write("Enter the N: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


        }
    }
}
