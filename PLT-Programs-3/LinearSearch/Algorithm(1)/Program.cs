using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int total,toFind;
            int[] listNumbers = new int[100];
            bool flag = false;
            Console.Write("Enter the number of numbers to be entered: ");
            total = int.Parse(Console.ReadLine());
            Console.Write($"Enter the {total} numbers: ");
            for (int i=0;i<total;i++)
            {
                listNumbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number to be searched: ");
            toFind = int.Parse(Console.ReadLine());
            for (int i=0;i<total;i++)
            {
                if (toFind == listNumbers[i])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.Write("Number found");
            else
                Console.Write("Number not found");
            Console.ReadLine();



        }
    }
}
