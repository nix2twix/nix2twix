using System;
using System.Collections.Generic;

namespace BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Form form = new Form();
            Application.Run(form);
        }
    }
}
