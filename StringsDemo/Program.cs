using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jeff Burkholder ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index).Trim();
            var lastName = fullName.Substring(index +1).Trim();
            Console.WriteLine("Firstname: " + firstName);
            Console.WriteLine("Lastname: " + lastName);

            var nameParts = fullName.Split(' ');
            Console.WriteLine("Firstname: " + nameParts[0]);
            Console.WriteLine("Lastname: " + nameParts[1]);

            var properName = fullName.Replace("Jeff", "Jeffrey").Trim();
            Console.WriteLine("Replace: '{0}'", properName);

            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine( "String is empty or null");
            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("String is whitespace or null");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine("Price to two decimals: " + price.ToString("C"));
            Console.WriteLine("Price to no decimals: " + price.ToString("C0"));

        }
    }
}
