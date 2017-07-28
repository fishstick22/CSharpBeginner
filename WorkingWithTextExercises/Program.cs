using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharp1Exercises.WorkingWithTextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WorkingWithTextExercises -- pick a category of solution to run:");
                Console.WriteLine("1) Strings");
                Console.WriteLine("2) ProceduralProgramming");
                Console.WriteLine("X) Exit");

                var pickSolutionCategory = Console.ReadLine();

                if (String.Compare(pickSolutionCategory, "X", true) == 0)
                {
                    Console.WriteLine("ok, thanks for playing...");
                    break;
                }
                else if (pickSolutionCategory == "1")
                {
                    RunStringsSolutions();
                }
                else if (pickSolutionCategory == "2")
                {
                    RunProceduralProgrammingSolutions();
                }
                else
                {
                    Console.WriteLine("you entered something I didn't recognize, try again!");
                    Console.WriteLine("--------------------------------");
                }
            }
        }

        private static void RunStringsSolutions()
        {
            var stringsSolutions = Enum.GetValues(typeof(StringsSolutions)).Cast<StringsSolutions>();

            Console.WriteLine("ControlFlowExercises -- pick a solution to run:");

            foreach (var solution in stringsSolutions)
            {
                Console.WriteLine("{0}) {1}", (int)solution + 1, solution);
            }

            Console.WriteLine("X) Exit");
            var pickSolutionNum = Console.ReadLine();
            StringsSolutions pickedSolution = 0;

            if (pickSolutionNum == "X")
            {
                Console.WriteLine("Ok, bye then...");
            }
            else if (Regex.IsMatch(pickSolutionNum, @"^\d+$"))
            {
                int solutionNum = 0;
                if (int.TryParse(pickSolutionNum, out solutionNum))
                {
                    pickedSolution = (StringsSolutions)solutionNum - 1;
                    Console.WriteLine("Running {0}...", pickedSolution);
                    Console.WriteLine("--------------------------------");
                }
            }

            Strings solutions = new Strings();

            switch (pickedSolution)
            {
                case StringsSolutions.Exercise1:
                    solutions.Exercise1();
                    break;
                case StringsSolutions.Exercise2:
                    solutions.Exercise2();
                    break;
                case StringsSolutions.Exercise3:
                    solutions.Exercise3();
                    break;
                case StringsSolutions.Exercise4:
                    solutions.Exercise4();
                    break;
                case StringsSolutions.Exercise5:
                    solutions.Exercise5();
                    break;
                default:
                    break;
            }
            Console.WriteLine("--------------------------------");
        }

        private static void RunProceduralProgrammingSolutions()
        {
            var proceduralProgrammingSolutions = Enum.GetValues(typeof(ProceduralProgrammingSolutions)).Cast<ProceduralProgrammingSolutions>();

            Console.WriteLine("ControlFlowExercises -- pick a solution to run:");

            foreach (var solution in proceduralProgrammingSolutions)
            {
                Console.WriteLine("{0}) {1}", (int)solution + 1, solution);
            }

            Console.WriteLine("X) Exit");
            var pickSolutionNum = Console.ReadLine();
            ProceduralProgrammingSolutions pickedSolution = 0;

            if (pickSolutionNum == "X")
            {
                Console.WriteLine("Ok, bye then...");
            }
            else if (Regex.IsMatch(pickSolutionNum, @"^\d+$"))
            {
                int solutionNum = 0;
                if (int.TryParse(pickSolutionNum, out solutionNum))
                {
                    pickedSolution = (ProceduralProgrammingSolutions)solutionNum - 1;
                    Console.WriteLine("Running {0}...", pickedSolution);
                    Console.WriteLine("--------------------------------");
                }
            }

            ProceduralProgramming solutions = new ProceduralProgramming();

            switch (pickedSolution)
            {
                case ProceduralProgrammingSolutions.Exercise1:
                    solutions.Exercise1();
                    break;
                case ProceduralProgrammingSolutions.Exercise2:
                    solutions.Exercise2();
                    break;
                case ProceduralProgrammingSolutions.Exercise3:
                    solutions.Exercise3();
                    break;
                case ProceduralProgrammingSolutions.Exercise4:
                    solutions.Exercise4();
                    break;
                case ProceduralProgrammingSolutions.Exercise5:
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
