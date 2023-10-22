using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
    public class Program
    {
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            var emails = new List<string>();
            var names = new List<string>();
            foreach (var to in contacts)
            {
                string[] line = to.Split(':');
                names.Add(line[0]);
                emails.Add(line[1]);
                if (!dictionary.ContainsKey(line[0])) dictionary.Add(line[0], emails);
            }
            return dictionary;
        }
        public static void Main()
        {
            var list = new List<string> {"Sasha: sasha1995@sasha.ru",
                                        "Masha: mash5@masha.ru",
                                        "Samara : samara2020@google.com"};
            OptimizeContacts(list);
            Console.ReadKey();
        }

    }
}