using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int i = 0,j;
            Console.Write("Enter the Word: ");
            word = Console.ReadLine();
            j = word.Length;
            j = j - 1;
            bool flag = true;
            while (i <= j) 
            {
                if (word[i] != word[j]) 
                {
                    flag = false;
                    break;
                }
                i++;
                j--;
            }
            if (flag)
            {
                Console.Write("It's Palindrome");
            }
            else 
            {
                Console.Write("It's not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
