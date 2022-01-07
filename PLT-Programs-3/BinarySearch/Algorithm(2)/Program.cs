using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, toFind,res;
            int[] listNumbers = new int[100];
            Console.Write("Enter the number of numbers to be entered: ");
            total = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers in sorted fashion:");
            for (int i=0;i<total;i++)
            {
                listNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number to be searched: ");
            toFind = int.Parse(Console.ReadLine());

            res = binarySearch(listNumbers, 0, total - 1, toFind);
            if (res == -1)
                Console.Write("Number not found");
            else
                Console.Write("Number found");
            Console.ReadLine();
        }


        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present
                // in right subarray
                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }
    }
}
