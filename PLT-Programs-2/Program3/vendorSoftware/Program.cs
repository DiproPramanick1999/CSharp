using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendorSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            float ratePerHour, hardware = 0, software = 0, externalConsultants = 0, clientInput = 0, total = 0, expenses = 0, VendorCost = 0;
            int hours;
            string clientBorne;
            Console.Write("Enter the dollar rate per hour: ");
            ratePerHour = float.Parse(Console.ReadLine());
            Console.Write("Is the vendor's hardware and software purchases borne by the client?(y/n): ");
            clientBorne = Console.ReadLine();
            Console.Write("Enter hours contributed by vendor resources: ");
            hours = int.Parse(Console.ReadLine());
            Console.Write("Enter cost of hardware resources: ");
            hardware = int.Parse(Console.ReadLine());
            Console.Write("Enter cost of software resources: ");
            software = int.Parse(Console.ReadLine());
            Console.Write("Enter cost of external consultants: ");
            externalConsultants = int.Parse(Console.ReadLine());


            if (clientBorne == "y")
            {
                Console.Write("Is the software commonly available?(y/n): ");
                string available = Console.ReadLine();
                if (available == "y")
                {
                    clientInput = (float)((double)hardware * 0.3 + software * 0.5);
                }
                else
                {
                    clientInput = (float)((double)software + hardware * 0.3);
                }
                VendorCost = hardware + software + externalConsultants;
                expenses = VendorCost - clientInput;
                total = ratePerHour * hours - expenses;
            }
            else
            {
                VendorCost = hardware + software + externalConsultants;
                expenses = VendorCost;
                total = ratePerHour * hours - expenses;
            }

            if (total > expenses)
            {
                Console.Write("The vendor experiences a profit of " + total);
            }
            else
            {
                Console.Write("The vendor experiences a loss of " + total);
            }
            Console.ReadLine();

        }
    }
}
