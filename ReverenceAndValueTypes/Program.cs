using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ReferenceAndValueTypes
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]);

            var number = 1;
            Increment(number);
            Console.WriteLine("number is now {0}", number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine("Person is now Age {0}", person.Age);
        }

        public static void Increment(int Number)
        {
            Number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
