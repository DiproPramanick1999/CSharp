using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=2, c=1, d=3, e=10,exp ;
            exp = a + b - c * d / e;
            Console.Write($"The value is {exp}");
            Console.ReadLine();

        }
    }
}
