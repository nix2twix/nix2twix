using System;
using System.Collections.Generic;
using System.Linq;

namespace BooleanAlgebra
{
    class BooleanFunctions
    {
        private Dictionary<char, int> variables = new Dictionary<char, int>();

        public Dictionary<char, int> Variables
        {
            get { return variables; }
        }

        //Присвоение значений переменным
        public void SetVariables(char[] keys, int[] values)
        {
            variables.Clear();
            for (int i = 0; i < keys.Length; i++)
            {
                variables.Add(keys[i], values[i]);
            }
        }

        //Получение переменных из строки
        public static List<char> GetAllVariablesFromString(string str)
        {
            List<char> variables = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    variables.Add(str[i]);
                }
            }

            return variables.Distinct().ToList();
        }

        //Логичсекое ИЛИ
        public int Disjunction(int A, int B)
        {
            return Math.Max(A, B);
        }

        //Логическое И
        public int Conjunction(int A, int B)
        {
            return Math.Min(A, B);
        }

        //Отрицание
        public int Negation(int A)
        {
            return (A + 1) % 2;
        }

        //Эквивалентность
        public int Equivalence(int A, int B)
        {
            return A == B ? 1 : 0;
        }

        //Импликация
        public int Implication(int A, int B)
        {
            return Disjunction(Negation(A), B);
        }

        //Неравнозначность
        public int Nonequivalence(int A, int B)
        {
            return Disjunction(Conjunction(Negation(A), B), Conjunction(A, Negation(B)));
        }

        //Штрих Шеффера
        public int ShefferFunction(int A, int B)
        {
            return Negation(Conjunction(A, B));
        }

        //Стрелка Пирса
        public int PeirceFunction(int A, int B)
        {
            return Negation(Disjunction(A, B));
        }

    }
}
