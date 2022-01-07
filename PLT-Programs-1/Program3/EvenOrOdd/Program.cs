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
            string[] arr = { "Even", "Odd" };
            int number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(arr[number%2]);
            Console.ReadLine();
        }
    }
}
