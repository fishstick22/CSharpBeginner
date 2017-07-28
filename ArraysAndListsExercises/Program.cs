using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp1Exercises.ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ArraysAndListsExercises -- pick a category of solution to run:");
                Console.WriteLine("1) Arrays");
                Console.WriteLine("2) Lists");
                Console.WriteLine("X) Exit");

                var pickSolutionCategory = Console.ReadLine();

                if (String.Compare(pickSolutionCategory, "X", true) == 0)
                {
                    Console.WriteLine("ok, thanks for playing...");
                    break;
                }
                else if (pickSolutionCategory == "1")
                {
                    RunArraysAndListsSolutions();
                }
                else if (pickSolutionCategory == "2")
                {
                    RunArraysAndListsSolutions();
                }
                else
                {
                    Console.WriteLine("you entered something I didn't recognize, try again!");
                    Console.WriteLine("--------------------------------");
                }
            }
        }

        private static void RunArraysAndListsSolutions()
        {
            var arraysAndListsSolutions = Enum.GetValues(typeof(ArraysAndListsSolutions)).Cast<ArraysAndListsSolutions>();

            Console.WriteLine("ArraysAndListsExercises -- pick a solution to run:");

            foreach (var solution in arraysAndListsSolutions)
            {
                Console.WriteLine("{0}) {1}", (int)solution + 1, solution);
            }

            Console.WriteLine("X) Exit");
            var pickSolutionNum = Console.ReadLine();
            ArraysAndListsSolutions pickedSolution = 0;

            if (pickSolutionNum == "X")
            {
                Console.WriteLine("Ok, bye then...");
            }
            else if (Regex.IsMatch(pickSolutionNum, @"^\d+$"))
            {
                int solutionNum = 0;
                if (int.TryParse(pickSolutionNum, out solutionNum))
                {
                    pickedSolution = (ArraysAndListsSolutions)solutionNum - 1;
                    Console.WriteLine("Running {0}...", pickedSolution);
                    Console.WriteLine("--------------------------------");
                }
            }
            else
            {
                throw new Exception("Fell Through Somehow");
            }

            ArraysAndLists solutions = new ArraysAndLists();

            switch (pickedSolution)
            {
                case ArraysAndListsSolutions.Exercise1:
                    solutions.Exercise1();
                    break;
                case ArraysAndListsSolutions.Exercise2:
                    solutions.Exercise2();
                    break;
                case ArraysAndListsSolutions.Exercise3:
                    solutions.Exercise3();
                    break;
                case ArraysAndListsSolutions.Exercise4:
                    solutions.Exercise4();
                    break;
                case ArraysAndListsSolutions.Exercise5:
                    solutions.Exercise5();
                    break;
                default:
                    Console.WriteLine("That solution does not exist!");
                    break;
            }
            Console.WriteLine("--------------------------------");
        }
    }
}