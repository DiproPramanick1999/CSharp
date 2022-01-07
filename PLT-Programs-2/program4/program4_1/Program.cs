using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	4, 16, 36, 64, … N 
            int num;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write(4 * (i + 1) * (i + 1) + " ");
            }
            Console.ReadLine();

            //uncomment the below code to run the following series
            //2.	1, 2, 3, 4, 5, 6, ...N 

            //int num;
            //Console.Write("Enter the number: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write(i+1+ " ");
            //}
            //Console.ReadLine();

            //uncomment the below code to run the followin series
            //3.  1, 4, 27, 256, 3125, ...N

            //int num;
            //Console.Write("Enter the number: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write(Math.Pow(i+1,i+1)+" ");
            //}
            //Console.ReadLine();

        }
    }
}
