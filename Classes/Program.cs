using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Classes.Math;

namespace CSharpFundamentals.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.Lastname = "Smith";
            john.Introduce();

            //Classes.Math.Calculator calc = new Math.Calculator();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
