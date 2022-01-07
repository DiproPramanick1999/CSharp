using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            //       Accept the item code, description, qty, and price of an item. Compute the total for the item.    
            //              a.Accept the user’s choice.If the choice is ‘y’ then accept the next set of inputs for a new item and compute the total.In this manner, compute the grand total for all the items purchased by the customer.
            //              b.If the grand total is more than Rs. 10, 000 /‐ then, the customer is allowed a discount of 10 %.
            //              c.If the grand total is less than Rs. 1, 000 /‐ and the customer chooses to pay by card, then a surcharge of 2.5 % is levied on the grand total.
            //              d.Display the grand total for the customer in number form and in words.

            int code, qty, price,total=0;
            string descp;
            char press;
            while (true)
            {
                Console.WriteLine("Accept the item code, description, qty, and price of an item:");
                code = int.Parse(Console.ReadLine());

                descp = Console.ReadLine();

                qty = int.Parse(Console.ReadLine());

                price = int.Parse(Console.ReadLine());

                Console.Write("Press 'y' to continue: ");
                press = Convert.ToChar(Console.ReadLine());

                total += (qty*price);
                if (press is 'y')
                {
                    continue;
                }
                else
                    break;
            }
            Console.Write($"Total Price is: {total}");
            if (total > 10000)
            {
                Console.WriteLine($"Total Cost after discount of 10% is {total-(0.1*total)}");
            }
            else if (total < 1000)
            {
                Console.WriteLine($"Total if paid by cash: {total}");
                Console.WriteLine($"Total if paid by card: {total + (total*0.025)}");
            }
            Console.ReadLine();
        }
    }
}
