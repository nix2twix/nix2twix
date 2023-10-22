using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{ 
    public class Complex
    {
        const double exp = 1e-8;
        double _realPart;
        double _imaginaryPart;
        double _argument;
        double _module;

        public double Module { get { return _module; } }
        public double Argument { get { return _argument; } }
        public double RealPart
        {
            get { return _realPart; }
            set { _realPart = value; }
        }
        public double ImaginaryPart
        {
            get { return _imaginaryPart; }
            set { _imaginaryPart = value; }
        }

        public Complex(Complex original)
        {
            var newNum = new Complex(original.RealPart, original.ImaginaryPart);
        }
        public Complex(double x, double y)
        {
            _realPart = x;
            _imaginaryPart = y;
            _module = Math.Sqrt(Math.Pow(_realPart, 2) + Math.Pow(_imaginaryPart, 2));

            if (_realPart > 0)
                _argument = Math.Atan(_imaginaryPart / _realPart);
            if (_realPart < 0 && _imaginaryPart >= 0)
                _argument = Math.PI - Math.Atan(Math.Abs(_imaginaryPart / _realPart));
            if (_realPart < 0 && _imaginaryPart < 0)
                _argument = Math.PI + Math.Atan(Math.Abs(_imaginaryPart / _realPart));
            if (_realPart == 0 && _imaginaryPart > 0)
                _argument = Math.PI / 2;
            if (_realPart == 0 && _imaginaryPart < 0)
                _argument = 3 * Math.PI / 2;
            if (_realPart == 0 && _imaginaryPart == 0)
                _argument = 0;
        }
        public Complex() : this(0, 0)
        {
            _module = 0;
            _argument = 0;
        }

        public Complex Pow(int degree)
        {
            double newModule = Math.Pow(this.Module, degree);
            double real = newModule * Math.Cos(this.Argument * degree);
            double imaginary = newModule * Math.Sin(this.Argument * degree);
            return new Complex(real, imaginary);
        }
        public Complex[] Sqrt(int degree)
        {
            Complex[] result = new Complex[degree];
            double newModule = Math.Pow(this.Module, 1.0 / degree);
            for (int i = 0; i < degree; i++)
            {
                double real = newModule * Math.Cos(this.Argument + 2 * Math.PI * i) / degree;
                double imaginary = newModule * Math.Sin((this.Argument + 2 * Math.PI * i) / degree);
                result[i] = new Complex(real, imaginary);
            }
            return result;
        }
        public static Complex operator +(Complex numA, Complex numB)
        {
            return new Complex 
            ( 
               numA.RealPart + numB.RealPart,
               numA.ImaginaryPart + numB.ImaginaryPart
            );
        }
        public static Complex operator -(Complex numA, Complex numB)
        {
            return new Complex
            (
               numA.RealPart + numB.RealPart,
               numA.ImaginaryPart + numB.ImaginaryPart
            );
        }
        public static Complex operator *(Complex numA, Complex numB)
        {
            return new Complex
            (
                numA.Module * numB.Module,
                numA.Argument + numB.Argument
            );
        }

        public static Complex operator /(Complex numA, Complex numB)
        {
            return new Complex
            (
                (numA.RealPart*numB.RealPart + numA.ImaginaryPart*numB.ImaginaryPart)
                        /(Math.Pow(numB.RealPart,2) + Math.Pow(numB.ImaginaryPart,2)),
                (numA.ImaginaryPart * numB.RealPart - numA.RealPart * numB.ImaginaryPart)
                        / (Math.Pow(numB.RealPart, 2) + Math.Pow(numB.ImaginaryPart, 2))
            );
        }

        public static bool operator ==(Complex numA, Complex numB)
        {
            return (
                numA.RealPart == numB.RealPart &&
                numA.ImaginaryPart == numB.ImaginaryPart
            );
        }

        public static bool operator !=(Complex numA, Complex numB)
        {
            return (
                numA.RealPart != numB.RealPart &&
                numA.ImaginaryPart != numB.ImaginaryPart
            );
        }

        public Complex GetConjugatePair()
        {
            return new Complex
            (
                _realPart = this.RealPart,
                _imaginaryPart = -this.ImaginaryPart
            );
        }
        public void PrintModule()
        {
            Console.WriteLine($"The module of a complex number: {_module:f2}");
        }
        public void PrintArgument()
        {
            double grad = (_argument * 180) / Math.PI;
            Console.WriteLine($"The argument of a complex number: {_argument:f2} radians or {grad:f2} degrees");
        }

        public string ToString()
        {
            string result = string.Empty;

            if (_realPart != 0 && _imaginaryPart > exp)
                result = $"\t\t\tCurrent number: {_realPart:f2} + {_imaginaryPart:f2}*i\n";

            if (_realPart != 0 && _imaginaryPart < 0 && Math.Abs(_imaginaryPart) > exp)
                result = $"\t\t\tCurrent number: {_realPart:f2} - {Math.Abs(_imaginaryPart):f2}*i\n";

            if (Math.Abs(_realPart) < exp && Math.Abs(_imaginaryPart) > exp)
                result = $"\t\t\tCurrent number: {_imaginaryPart:f2}*i\n";

            if (Math.Abs(_realPart) > exp && Math.Abs(_imaginaryPart) < exp)
                result = $"\t\t\tCurrent number: {_realPart:f2}\n";

            if (_realPart == 0 && _imaginaryPart == 0)
                result = $"\t\t\tCurrent number: 0\n";

            result += $"\t\t\tThe module of a complex number: {_module:f2}\n";
            double grad = (_argument * 180) / Math.PI;
            result += $"\t\t\tThe argument of a complex number: {_argument:f2} radians or {grad:f2} degrees\n";
            return result;
        }

        public string TrigonometricToString()
        {
            return $"Current number: {_module:f2}*(cos({GetArgumentPI()}) + i*sin({GetArgumentPI()}))";
        }
        public void Print()
        {

            if (_realPart != 0 && _imaginaryPart > exp)
                Console.WriteLine($"Current number: {_realPart:f2} + {_imaginaryPart:f2}*i");

            if (_realPart != 0 && _imaginaryPart < 0 && Math.Abs(_imaginaryPart) > exp)
                Console.WriteLine($"Current number: {_realPart:f2} - {Math.Abs(_imaginaryPart):f2}*i");

            if (Math.Abs(_realPart) < exp && Math.Abs(_imaginaryPart) > exp)
                Console.WriteLine($"Current number: {_imaginaryPart:f2}*i");

            if (Math.Abs(_realPart) > exp && Math.Abs(_imaginaryPart) < exp)
                Console.WriteLine($"Current number: {_realPart:f2}");

            if (_realPart == 0 && _imaginaryPart == 0)
                Console.WriteLine($"Current number: 0");

            this.PrintModule();
            this.PrintArgument();
        }

        public void TrigonometricPrint()
        {
            Console.WriteLine($"Current number: {_module:f2}*(cos({GetArgumentPI()}) + i*sin({GetArgumentPI()}))");
        }
        public string GetArgumentPI()
        {
            string result = string.Empty;
            int alpha = Convert.ToInt32((_argument * 180) / Math.PI);
            if (alpha == 0)
                result = $"0";
            {
                int numerator = alpha / GCD(alpha, 180);
                int denominator = 180 / GCD(alpha, 180);
                if (Math.Abs(numerator) > 1 && Math.Abs(denominator) > 1)
                    result = $"{alpha / GCD(alpha, 180)}*PI/{180 / GCD(alpha, 180)}";
                if (Math.Abs(numerator) == 1 && Math.Abs(denominator) > 1)
                {
                    if (Math.Abs(numerator) == 1 && Math.Abs(denominator) > 1)
                    {
                        if (numerator == 1)
                            result = $"PI/{180 / GCD(alpha, 180)}";
                        if (numerator == -1)
                            result = $"-PI/{180 / GCD(alpha, 180)}";
                    }
                }
                if (Math.Abs(numerator) == 1 && Math.Abs(denominator) == 1)
                    result = $"PI";
            }
            return result;
        }

        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a | b;
        }
    }
}
