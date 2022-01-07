using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter the number: ");
            str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int num;
            string[] str1 = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
            for (int i =0 ; i < str.Length; i++)
            {
                num = (int)Char.GetNumericValue(ch[i]);
                Console.Write(str1[num]+" ");
            }
            Console.ReadLine();
        }
    }
}
