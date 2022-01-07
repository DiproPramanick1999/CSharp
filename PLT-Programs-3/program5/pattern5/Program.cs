using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.a 1
            //    2 3
            //    4 5 6
            //    7 8 9 10
            //    :    
            //    N rows

            int num, count = 1;
            Console.Write("Enter the value N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(count);
                    count += 1;

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //5.b 1
            //    1 2
            //    3 5 8
            //    :    
            //    N rows

            //int num, term=1;
            //Console.Write("Enter the value N: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write((fibonacci(term++)) + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int fibonacci(int a)
            //{
            //    if (a <= 1)
            //    {
            //        return a;
            //    }
            //    return (fibonacci(a - 1) + fibonacci(a - 2));
            //}
            //Console.ReadLine();

        }
    }
}
