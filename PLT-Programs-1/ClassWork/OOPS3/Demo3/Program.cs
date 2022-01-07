using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicIntArray dynamicArray = new DynamicIntArray();
            dynamicArray.Add(2);
            dynamicArray.Add(3);
            //Console.WriteLine("hello"+dynamicArray.Length);
            for (int i = 0; i < dynamicArray.Length; i++) ;
            {
                int n = dynamicArray.Get(i);
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
    class DynamicIntArray
    {
        private int[] array= new int[10];
        
        int index = 0;
        public int Length { get {
                return index;
            } }

        public void Add(int v)
        {
            if (index < array.Length)
            {
                array[index++] = v;
            }
            else
            {
                int[] arraynew = new int[array.Length * 2];
                //Array.Copy(array, arraynew,array.Length);
                //array = arraynew;
                Array.Resize(ref array,index*2);// or array.Length
                array[index++] = v;
            }

        }
        public int Get(int i) 
        {
            return array[i];
        }
    }
}
