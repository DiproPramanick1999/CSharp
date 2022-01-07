using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFibonacci
{
    class Program
    {
        static bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        
        static bool isFibonacci(int n)
        {
            // n is Fibonacci if one of
            // 5*n*n + 4 or 5*n*n - 4 or
            // both are a perfect square
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(isFibonacci(number) ? number +" is a Fibonacci Number" : number + " is a not Fibonacci Number");
            Console.ReadLine();
        }
    }
}
