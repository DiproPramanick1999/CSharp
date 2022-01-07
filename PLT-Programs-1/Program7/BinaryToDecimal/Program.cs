using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem,binary,decVal=0,baseVal=1;
            Console.Write("Enter the number: ");
            binary = int.Parse(Console.ReadLine());
            while (binary > 0)
            {
                rem = binary % 10;
                binary = binary / 10;
                decVal += rem * baseVal;
                baseVal = baseVal * 2;
            }
            Console.Write(decVal);
            Console.ReadLine();
        }
    }
}
