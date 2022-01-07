using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeFractional
{
    class Program
    {
        static void Main(string[] args)
        {
            double num,a,b;
            Console.WriteLine("Enter the Number");
            num = double.Parse(Console.ReadLine());
            a = (int)(num);
            //Console.Write($"{a}");
            b = num - a;
            Console.Write($"Fractional Value {b} and Whole Value {a}");
            Console.ReadLine();

        }
    }
}
