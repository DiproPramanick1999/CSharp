using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2a. 1
            //    22
            //    333
            //    4444
            //    :    
            //    N rows
            int num;
            Console.Write("Enter the N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i+1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //2b. 12345
            //    12345
            //    12345
            //    12345
            //    :  
            //    N rows

            //int num;
            //Console.Write("Enter the N: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write(j + 1);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
