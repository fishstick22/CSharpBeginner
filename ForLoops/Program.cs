using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            for (int i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
