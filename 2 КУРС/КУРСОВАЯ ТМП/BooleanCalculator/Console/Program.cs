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
                /*�������� ���������� ������ BooleanFunctions*/
                BooleanFunctions booleanFunctions = new BooleanFunctions();

                /*���� �������*/
                Console.WriteLine("\nNotation keys: ");
                Console.WriteLine("\tDisjunction � \"+\" | Conjunction � \"*\" | Negation � \"!\" | Equivalence � \"~\" | Implication � \">\" or \"<\"");
                Console.Write("Formula: ");

                string formula = Console.ReadLine();
                char[] variables = BooleanFunctions.GetAllVariablesFromString(formula);

                /*���� �������� ��� ��������������� ����������*/
                Console.WriteLine("Enter values of following variables separated by space:");
                Console.Write($"\t{string.Join(" ", variables)}\n\t");
                int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                booleanFunctions.SetVariables(variables, values);

                /*������� ���������*/
                Console.WriteLine($"\nResult: {RPN.Calculate(formula, booleanFunctions)}\n");
            }
        }
    }
}
