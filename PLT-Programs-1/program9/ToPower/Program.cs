using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToPower
{
    class Program
    {
        public static int power(int x,int y) {
            if (x == 0)
                return 0;
            else if (y == 0)
                return 1;
            else {
                return x * power(x, y - 1);
            }

        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write(power(x, y));
            Console.ReadLine();
        }
    }
}

