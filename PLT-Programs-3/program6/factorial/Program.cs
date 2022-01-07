using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static int recursion(int num) {
            if (num == 0)
                return 1;
            return num * recursion(num - 1);
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the num: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(recursion(num));
            Console.ReadLine();

        }
    }
}
