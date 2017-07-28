using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Jeff";
            var lastName = "Burkholder";

            var fullname = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi John
look at the folling paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
