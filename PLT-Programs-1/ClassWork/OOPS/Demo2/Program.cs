using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //int s = calculator.Sum(19, 29);

            PrintManager pMnger = new PrintManager();
            pMnger.Print("Invoice.doc")
        }
    }

    class Calculator
    {
        //static constructor should be parameterless
        //business object because no property
        public int Sum(int fno,int sno)//these are instance method so we hav to create object of calculator
        {
            return fno + sno;
        }

        //int s;
        //static public int Sum(int fno, int sno)
        //{
        //    s = fno + sno;//its not possible as s is field variable and we are using static method either we hav to remove static from method or variable as static as static int s;
        //    return s;
        //}


    }

    class PrintManager
    {
        //public static readonly PrintManager Instance = new PrintManager();
        private static PrintManager pmgr;
        private PrintManager() {
        }
        public void Print(string document)
        {
            Console.WriteLine($"Printing the {document}");
        }
        //statci method cant be inherited
        static public PrintManager  GetInstance() 
        {
            if (pmgr==null) {
                pmgr = new PrintManager();
            }
            return pmgr;
        }
    }
}
