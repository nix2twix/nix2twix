using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public double Add(double x, double y) => x + y;
        public double Subtract(double x, double y) => x - y;
        public double Multiply(double x, double y) => x * y;
        public double Pow(double x, int degree) => Math.Pow(x, degree);
        public double Divide(double x, double y) => x / y;


    }
}
