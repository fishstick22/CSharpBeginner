using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Jeff Burkholder";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
