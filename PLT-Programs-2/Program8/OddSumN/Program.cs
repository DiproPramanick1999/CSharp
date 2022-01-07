using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddSumN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            Console.Write("Enter the value of N: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i<= num; i = i + 2)
            {
                sum += i;
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
