using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;         // using var defaults to int
            var count = 10;          // int
            var totalPrice = 20.95f; //float
            var character = 'A';     // single quote
            var firstName = "Mosh";  // string 
            var isWorking = false;   // boolean

            Console.WriteLine(number);  // cw->Tab
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
