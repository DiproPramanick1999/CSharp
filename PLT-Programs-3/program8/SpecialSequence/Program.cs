using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 2, 4, 6, 7,10, 10,14… N    
            int first = 1, second = 2, n;
            Console.Write("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            while (first <= n && second <= n)
            {
                Console.Write(first + " ");
                first += 3;
                Console.Write(second + " ");
                second += 4;
            }
            Console.ReadLine();

            //uncomment the below code to get the following output
            //1, 5, 8, 14, 27, 49, … N

            //int a =1,b=5,c=8,d,n;
            //Console.Write("Enter the number: ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("1 5 8 ");
            //for(int i =2;i<n;i++)
            //{
            //    d = a + b + c;
            //    Console.Write(d+" ");
            //    a = b;
            //    b = c;
            //    c = d;
            //}
            //Console.ReadLine();
        }
    }
}
