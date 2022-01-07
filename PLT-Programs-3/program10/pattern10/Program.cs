using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.a 1
            //     ‐4  9
            //    ‐16 25 ‐36
            //      :   :  
            //     N rows

            int num, count = 1, counter = 1;
            Console.Write("Enter the value of N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (counter % 2 == 0)
                    {
                        Console.Write("-");
                    }
                    counter += 1;
                    Console.Write(count * count);
                    Console.Write(' ');
                    count += 1;

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //10.b 1
            //     1 2
            //     6 24 120
            //        :   :   
            //     N rows

            //int num,count=0;
            //Console.Write("Enter the value of N: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(recursion(count));
            //        Console.Write(" ");
            //        count++;
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            //int recursion(int a)
            //{
            //    if (a == 0)
            //        return 1;
            //    return a * recursion(a - 1);
            //}

        }
    }
}
