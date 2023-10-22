using System;
using System.IO;

namespace Pluralize
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            /*/ Это пример ввода сложных данных из файла.
            // Циклы, строки, массивы будут рассмотрены на лекциях чуть позже, но это не должно быть препятствием вашему любопытству! :)
            var lines = File.ReadAllLines("rubles.txt");
            var hasErrors = false;
            foreach (var line in lines)
            {
                var words = line.Split(' ');
                var count = int.Parse(words[0]);
                var rightAnswer = words[1];
                var pluralizedRubles = PluralizeTask.PluralizeRubles(count);
                if (pluralizedRubles != rightAnswer)
                {
                    hasErrors = true;
                    Console.WriteLine("Wrong answer: {0} {1}", count, pluralizedRubles);
                }
            }

            if (!hasErrors)
                Console.WriteLine("Correct!");*/
            Console.WriteLine("111 " + PluralizeTask.PluralizeRubles(111));
            Console.WriteLine("121 "+PluralizeTask.PluralizeRubles(121));
            Console.WriteLine("21 " +PluralizeTask.PluralizeRubles(21));
            Console.WriteLine("1000 " + PluralizeTask.PluralizeRubles(1000));
            Console.WriteLine("97 " + PluralizeTask.PluralizeRubles(97));
            Console.WriteLine("0 " + PluralizeTask.PluralizeRubles(0));
            Console.WriteLine("400 " + PluralizeTask.PluralizeRubles(0));
            Console.WriteLine("23 " + PluralizeTask.PluralizeRubles(0));
            Console.ReadKey();
        }
    }
}