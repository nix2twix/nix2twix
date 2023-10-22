using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ComplexNumbers;

class Program
{
    static void Main()
    {
        //for (int i = 0; i <= 100; i+=10)
        //{
        //    Console.Write("\rloading... \t\t\t" + i.ToString() + "%");
        //    System.Threading.Thread.Sleep(100);
        //} Console.Clear();

        var num = new Complex(0,0);
        int option = -1;

        do
        {
            Console.WriteLine("\n\t\t\t---> Menu:");
            Console.WriteLine("\t\t\t1 - Put in a new complex number");
            Console.WriteLine("\t\t\t2 - Get an argument of the current complex number");
            Console.WriteLine("\t\t\t3 - Get an module of the current complex number");
            Console.WriteLine("\t\t\t4 - Get a complex conjugate pair of the current complex number");
            Console.WriteLine("\t\t\t5 - Take the current complex number to a power");
            Console.WriteLine("\t\t\t6 - Take a root of the degree of the current complex number");
            Console.WriteLine("\t\t\t7 - Print the current complex number in trigonometric form");
            Console.WriteLine("\t\t\t8 - Print the current complex number in algebraic form");
            Console.WriteLine("\t\t\t9 - Add another number to the current complex number");
            Console.WriteLine("\t\t\t10 - Subtract another number from the current complex number");
            Console.WriteLine("\t\t\t11 - Multiply another number with the current complex number");
            Console.WriteLine("\t\t\t12 - Divide the current complex number by another number");
            Console.WriteLine("\t\t\t13 - Exit");
            Console.Write("\t\t\tYour option -> ");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        {
                            var input = ReadComplex();
                            num = new Complex(input.Key, input.Value);
                            break;
                        }
                    case 2:
                        {
                            double grad = (num.Argument * 180) / Math.PI;
                            Console.WriteLine($"The argument of a complex number: {num.Argument:f2} radians or {grad:f2} degrees");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"The module of a complex number: {num.Module:f2}");
                            break;
                        }
                    case 4:
                        {
                            num.GetConjugatePair().Print();
                            break;
                        }
                    case 5:
                        {
                            int degree;
                            Console.Write("\t\t\tInput the degree -> ");
                            degree = int.Parse(Console.ReadLine());
                            num = num.Pow(degree);
                            break;
                        }
                    case 6:
                        {
                            int degree;
                            Console.Write("\t\t\tInput the degree of root -> ");
                            degree = int.Parse(Console.ReadLine());
                            int i = 1;
                            foreach (var item in num.Sqrt(degree))
                            {
                                Console.WriteLine($"The {1} root is:");
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(num.TrigonometricToString());
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("\t\t\t" + num.ToString());
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("\t\t\tInput the second number:");
                            var input = ReadComplex();
                            var numB = new Complex(input.Key, input.Value);
                            num = num + numB;
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("\t\t\tInput the second number:");
                            var input = ReadComplex();
                            var numB = new Complex(input.Key, input.Value);
                            num = num - numB;
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("\t\t\tInput the second number:");
                            var input = ReadComplex();
                            var numB = new Complex(input.Key, input.Value);
                            num = num * numB;
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("\t\t\tInput the second number:");
                            var input = ReadComplex();
                            var numB = new Complex(input.Key, input.Value);
                            num = num / numB;
                            break;
                        }
                    default:
                        {
                            option = 13;
                            break;
                        }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\tIncorrect format of input string! Please, try again!\n");
                continue;
            }
        } while (option != 13);

        Console.WriteLine("\n\t\t\tThe work is completed successfully!\n");

        var numA = new Complex(1, 2);
        var numT = new Complex(1, 3);
        var numC = numA + numT;
        Console.WriteLine(numC.ToString());
    }

    public static KeyValuePair<double, double> ReadComplex()
    {
        var target = new Regex(@"(sqrt)\([0-9]+\)");
        double x, y;

        Console.Write("\t\t\tThe real part -> ");
        var input = Console.ReadLine();
        MatchCollection match = target.Matches(input);

        double num = 0.0;

        if (input.Contains("sqrt"))
        {
            num = Convert.ToDouble(match[0].ToString()[5].ToString());
            x = Math.Sqrt(num);
        }
        else
            x = double.Parse(input);

        Console.Write("\t\t\tThe imaginary part -> ");
        input = Console.ReadLine();
        match = target.Matches(input);

        if (input.Contains("sqrt"))
        {
            num = Convert.ToDouble(match[0].ToString()[5].ToString());
            y = Math.Sqrt(num);
        }
        else
            y = double.Parse(input);
        return new KeyValuePair<double, double>(x, y);
    }
}