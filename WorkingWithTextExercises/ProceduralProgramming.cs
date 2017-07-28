﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1Exercises.WorkingWithTextExercises
{
    public enum ProceduralProgrammingSolutions
    {
        Exercise1,
        Exercise2,
        Exercise3,
        Exercise4,
        Exercise5
    }
    public class ProceduralProgramming
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        internal void Exercise1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));


            var message = IsConsecutiveList(numbers) ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
        public bool IsConsecutiveList(List<int> list)
        {
            // Note that I've copied the list to a new array because I didn't want callign Sort()
            // impact the argument of this method. Caller of this method only expects a true/false answer 
            // as a result of this call. So, this method should not have a side-effect.
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        internal void Exercise2()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            if (ContainsDuplicates(numbers))
                Console.WriteLine("Duplicate");
        }
        public bool ContainsDuplicates(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        internal void Exercise3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (IsValidTime(input))
            {
                Console.WriteLine("Valid Time");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
                
        }
        public bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;

            var components = time.Split(':');
            if (components.Length != 2)
                return false;
            
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        internal void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            Console.WriteLine(GetVariableName(input));
        }
        public string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }


        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        internal void Exercise5()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();


            Console.WriteLine(CountVowels(input));
        }
        public int CountVowels(string word)
        {
            var vowels = new List<char>(new char[] {'a', 'e', 'o', 'u', 'i'});
            var vowelsCount = 0;

            // Note the ToLower() here. This is used to count for both A and a. 
            foreach (var character in word.ToLower())
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            return vowelsCount;
        }

    }
}
