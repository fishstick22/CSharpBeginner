using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a very very very very long text.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

       
    }
}