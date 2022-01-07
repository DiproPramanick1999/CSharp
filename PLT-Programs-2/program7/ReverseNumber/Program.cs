using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,str1;
            str = Console.ReadLine();
            int k = str.Length;
            char[] arr1 = str.ToCharArray();
            char[] arr2 = new char[k];
            int n = 0,num;
            for (int i = k-1;i>=0;i--) 
            {
                Console.Write(arr1[i]);
                arr2[n] = arr1[i];
                n += 1;
            }
            str1 = new string(arr2);
            num = int.Parse(str1);
            Console.Write($"Integer is {num}");
            Console.ReadLine();

        }
    }
}
