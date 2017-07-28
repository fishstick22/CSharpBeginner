using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.IfElseAndSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }

            bool isGoldCustomer = true;

            //  If you select a block of code and use the key sequence Ctrl+K+C, 
            // you'll comment out the section of code. Ctrl+K+U will uncomment the code.

            //float price;  
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season) // tab tab to create snippet
            {
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("Spring/Summer ...");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn!");
                    break;
                case Season.Winter:
                    break;
                default:
                    Console.WriteLine("Don't recognize that season");
                    break;
            }
        }
    }
}
