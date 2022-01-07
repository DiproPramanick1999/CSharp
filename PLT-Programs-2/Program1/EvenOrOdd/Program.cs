using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write("It is even");
            }
            else {
                Console.Write("It is odd");
            }
            Console.ReadLine();
        }
    }
}
