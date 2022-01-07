using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Boolean flag = true;
            int sum = 0;

            Console.WriteLine("Prime numbers between "
             + num1 + " and " + num2);
            for (int k = num1; k <= num2; k++)
            {
                //loop the iterations for k/2 times
                for (int i = 2; i <= k / 2; i++)
                {
                    if ((k % i) == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.Write(k+" ");
                    sum += k;
                }
                flag = true;
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}

