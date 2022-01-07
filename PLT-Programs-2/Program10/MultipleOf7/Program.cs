using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOf7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, c = 1;
            while (true)
            {
                if ((60 * i + 1) % 7 == 0)
                {
                    if (c != 3)
                        Console.Write((60 * i + 1) + " ");
                    c++;
                    if (c == 5)
                        break;
                }
                i++;
            }
            Console.Read();

        }
    }
}
