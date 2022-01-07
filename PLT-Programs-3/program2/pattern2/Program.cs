using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.a 12345
            //    12345
            //    12345
            //    12345
            //    :  
            //    N rows

            int num,count=1;
            Console.Write("Enter the N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(count);
                    count += 1;
                }
                count = 1;
                Console.WriteLine();
            }
            Console.ReadLine();

            //2.b *
            //    **
            //    ***
            //    ****
            //    : 
            //    N rows
            //int num,count=1;
            //Console.Write("Enter the N: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < count; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    count += 1;
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
