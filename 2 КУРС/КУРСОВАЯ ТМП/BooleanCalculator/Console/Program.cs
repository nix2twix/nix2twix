using System;
using System.Collections.Generic;

namespace BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());

            while (true)
            {
                /*—оздание экземпл€ра класса BooleanFunctions*/
                BooleanFunctions booleanFunctions = new BooleanFunctions();

                /*¬вод формулы*/
                Console.WriteLine("\nNotation keys: ");
                Console.WriteLine("\tDisjunction Ч \"+\" | Conjunction Ч \"*\" | Negation Ч \"!\" | Equivalence Ч \"~\" | Implication Ч \">\" or \"<\"");
                Console.Write("Formula: ");

                string formula = Console.ReadLine();
                char[] variables = BooleanFunctions.GetAllVariablesFromString(formula);

                /*¬вод значений дл€ соответствующих переменных*/
                Console.WriteLine("Enter values of following variables separated by space:");
                Console.Write($"\t{string.Join(" ", variables)}\n\t");
                int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                booleanFunctions.SetVariables(variables, values);

                /*¬ыводим результат*/
                Console.WriteLine($"\nResult: {RPN.Calculate(formula, booleanFunctions)}\n");
            }
        }
    }
}
