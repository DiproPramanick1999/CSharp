using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fno, sno, swap;
            Console.Write("Enter the first Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            sno = int.Parse(Console.ReadLine());
            Console.WriteLine($"First Number is: {fno} & Second Number is: {sno}");
            Console.Write("Press Enter to swap");
            Console.ReadLine();
            swap = fno;
            fno = sno;
            sno = swap;
            Console.Write($"First Number is: {fno} & Second Number is: {sno}");
            Console.ReadLine();

        }
    }
}
