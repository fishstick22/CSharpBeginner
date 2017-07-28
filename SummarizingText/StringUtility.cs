﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.SummarizingText
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length;
                if (totalChars > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
