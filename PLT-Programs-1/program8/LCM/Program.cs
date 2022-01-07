﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        static int LCM(int[] arr,int n)
        {
            // Find the maximum value in arr[]
            int max_num = 0;
            for (int i = 0; i < n; i++)
            {
                if (max_num < arr[i])
                {
                    max_num = arr[i];
                }
            }

            // Initialize result
            long res = 1;

            // Find all factors that are present
            // in two or more array elements.
            int x = 2; // Current factor.
            while (x <= max_num)
            {
                // To store indexes of all array
                // elements that are divisible by x.
                ArrayList indexes = new ArrayList();
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] % x == 0)
                    {
                        indexes.Add(j);
                    }
                }

                // If there are 2 or more array elements
                // that are divisible by x.
                if (indexes.Count >= 2)
                {
                    // Reduce all array elements divisible
                    // by x.
                    for (int j = 0; j < indexes.Count; j++)
                    {
                        arr[(int)indexes[j]] = arr[(int)indexes[j]] / x;
                    }

                    res = res * x;
                }
                else
                {
                    x++;
                }
            }

            // Then multiply all reduced
            // array elements
            for (int i = 0; i < n; i++)
            {
                res = res * arr[i];
            }

            return (int)res;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 10 };
            int len = arr.Length;
            //Console.Write("Enter the Array: ");
            Console.Write(LCM(arr,len));
            Console.ReadLine();
        }
    }
}
