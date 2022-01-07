using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            int principal, rate, time, simpleInterest;
            Console.Write("Enter the Principal Amount: ");
            principal = int.Parse(Console.ReadLine());
            Console.Write("Enter the Rate: ");
            rate = int.Parse(Console.ReadLine());
            Console.Write("Enter the Time ");
            time = int.Parse(Console.ReadLine());
            simpleInterest = (principal * rate * time) / 100;
            Console.Write($"The S.I is {simpleInterest}");
            Console.ReadLine();
        }
    }
}
