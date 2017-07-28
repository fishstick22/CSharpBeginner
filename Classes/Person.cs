using System;

namespace CSharpFundamentals.Classes
{
    public class Person
    {
        public string FirstName;
        public string Lastname;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + Lastname); ;
        }
    }
}
