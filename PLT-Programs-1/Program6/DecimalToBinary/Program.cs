using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            int[] binary = new int[10];
            Console.Write("Enter the decimal number: ");
            num = int.Parse(Console.ReadLine());
            for (i=0;num>0;i++) 
            {
                binary[i] = num % 2;
                num = num / 2;
            }
            for (i = i -1;i>=0;i --) {
                Console.Write(binary[i]);
            }
            Console.ReadLine();
        }
    }
}
