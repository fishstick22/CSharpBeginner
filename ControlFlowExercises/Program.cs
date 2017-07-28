using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp1Exercises.ControlFlowExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ControlFlowExercises -- pick a category of solution to run:");
                Console.WriteLine("1) Conditionals");
                Console.WriteLine("2) Loops");
                Console.WriteLine("X) Exit");

                var pickSolutionCategory = Console.ReadLine();

                if (String.Compare(pickSolutionCategory, "X", true) == 0)
                {
                    Console.WriteLine("ok, thanks for playing...");
                    break;
                }
                else if (pickSolutionCategory == "1")
                {
                    RunConditionalSolutions();
                }
                else if (pickSolutionCategory == "2")
                {
                    RunLoopSolutions();
                }
                else
                {
                    Console.WriteLine("you entered something I didn't recognize, try again!");
                    Console.WriteLine("--------------------------------");
                }
            }
            
        }

        private static void RunConditionalSolutions()
        {
            var conditionalsSolutions = Enum.GetValues(typeof(ConditionalsSolutions)).Cast<ConditionalsSolutions>();

            Console.WriteLine("ControlFlowExercises -- pick a solution to run:");

            foreach (var solution in conditionalsSolutions)
            {
                Console.WriteLine("{0}) {1}", (int)solution+1, solution);
            }

            Console.WriteLine("X) Exit");
            var pickSolutionNum = Console.ReadLine();
            ConditionalsSolutions pickedSolution = 0;

            if (pickSolutionNum == "X")
            {
                Console.WriteLine("Ok, bye then...");
            }
            else if (Regex.IsMatch(pickSolutionNum, @"^\d+$"))
            {
                int solutionNum = 0;
                if (int.TryParse(pickSolutionNum, out solutionNum))
                {
                    pickedSolution = (ConditionalsSolutions)solutionNum-1;
                    Console.WriteLine("Running {0}...", pickedSolution);
                    Console.WriteLine("--------------------------------");
                }
            }

            Conditionals solutions = new Conditionals();

            switch (pickedSolution)
            {
                case ConditionalsSolutions.Exercise1:
                    solutions.Exercise1();
                    break;
                case ConditionalsSolutions.Exercise2:
                    solutions.Exercise2();
                    break;
                case ConditionalsSolutions.Exercise3:
                    solutions.Exercise3();
                    break;
                case ConditionalsSolutions.Exercise4:
                    solutions.Exercise4();
                    break;
                default:
                    break;
            }
            Console.WriteLine("--------------------------------");
        }

        private static void RunLoopSolutions()
        {
            var loopsSolutions = Enum.GetValues(typeof(LoopsSolutions)).Cast<LoopsSolutions>();

            Console.WriteLine("ControlFlowExercises -- pick a solution to run:");

            foreach (var solution in loopsSolutions)
            {
                Console.WriteLine("{0}) {1}", (int)solution + 1, solution);
            }

            Console.WriteLine("X) Exit");
            var pickSolutionNum = Console.ReadLine();
            LoopsSolutions pickedSolution = 0;

            if (pickSolutionNum == "X")
            {
                Console.WriteLine("Ok, bye then...");
            }
            else if (Regex.IsMatch(pickSolutionNum, @"^\d+$"))
            {
                int solutionNum = 0;
                if (int.TryParse(pickSolutionNum, out solutionNum))
                {
                    pickedSolution = (LoopsSolutions)solutionNum - 1;
                    Console.WriteLine("Running {0}...", pickedSolution);
                    Console.WriteLine("--------------------------------");
                }
            }

            Loops solutions = new Loops();

            switch (pickedSolution)
            {
                case LoopsSolutions.Exercise1:
                    solutions.Exercise1();
                    break;
                case LoopsSolutions.Exercise2:
                    solutions.Exercise2();
                    break;
                case LoopsSolutions.Exercise3:
                    solutions.Exercise3();
                    break;
                case LoopsSolutions.Exercise4:
                    solutions.Exercise4();
                    break;
                case LoopsSolutions.Exercise5:
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
