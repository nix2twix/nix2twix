using System;
using System.Collections.Generic;

namespace BooleanAlgebra
{
    class Handler
    {
        // Метод возвращает true, если проверяемый символ - оператор
        static private bool IsOperator(char s) => ("+*!~><()^↓|".IndexOf(s) != -1);

        // Метод возвращает приоритет оператора
        static private byte GetPriority(char s)
        {
            return s switch
            {
                '(' => 0,
                ')' => 1,
                '!' => 2,
                '|' => 3,
                '↓' => 3,
                '*' => 3,
                '+' => 4,
                '^' => 4,
                '>' => 5,
                '<' => 5,
                '~' => 6,
                _ => 7,
            };
        }

        // Метод формирует постфиксную запись
        static private string ConvertToRPN(string input)
        {
            string output = string.Empty;
            Stack<char> stackForOperations = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++)
            {
                if (" ".IndexOf(input[i]) != -1) //Пропуск пробела
                {
                    continue;                    //Переход к следующему символу
                }

                //Если символ - буква, то добавляем к строке хранения выражения
                if (char.IsLetter(input[i]))
                {
                    output += input[i];
                    i++;

                    if (i == input.Length)
                    {
                        break; //Если символ - последний, то выход из цикла
                    }
                }

                //Если символ - оператор
                if (IsOperator(input[i]))
                {
                    if (input[i] == '(')
                    {
                        stackForOperations.Push(input[i]); //Записываем открывающую скобку в стек
                    }
                    else if (input[i] == ')')
                    {
                        //Выписываем все операторы до открывающей скобки в строку
                        char s = stackForOperations.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = stackForOperations.Pop();
                        }
                    }
                    else 
                    {
                        if (stackForOperations.Count > 0) //Если стек не пустой
                        {
                            //Приоритет оператора не больше приоритета оператора на вершине стека
                            if (GetPriority(input[i]) <= GetPriority(stackForOperations.Peek()) && input[i] != '!')
                            {
                                output += stackForOperations.Pop().ToString() + " "; //Добавляем последний оператор в строку с выражением
                            }
                        }

                        //В противном случае добавляем оператор на вершину стека
                        stackForOperations.Push(char.Parse(input[i].ToString()));
                    }
                }
            }

            //Считываем из стека все оставшиеся операторы
            while (stackForOperations.Count > 0)
            {
                output += stackForOperations.Pop() + " ";
            }

            return output; //Возврат выражения в постфиксной записи
        }

        //Вычисление выражения алгебры логики
        static private int Counting(string input, BooleanFunctions booleanFunctions)
        {
            int result = 0;
            Stack<int> temp = new Stack<int>(); 

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    temp.Push(booleanFunctions.Variables[input[i]]);
                }
                else if (IsOperator(input[i]))
                {
                    int a = temp.Pop();

                    switch (input[i]) 
                    {
                        case '+':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Disjunction(b, a);
                                break;
                            }
                        case '*':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Conjunction(b, a);
                                break;
                            }
                        case '~':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Equivalence(b, a);
                                break;
                            }
                        case '>':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Implication(b, a);
                                break;
                            }
                        case '<':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Implication(a, b);
                                break;
                            }
                        case '!':
                            result = booleanFunctions.Negation(a);
                            break;
                        case '^':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.Nonequivalence(a, b);
                                break;
                            }
                        case '|':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.ShefferFunction(a, b);
                                break;
                            }
                        case '↓':
                            {
                                int b = temp.Pop();
                                result = booleanFunctions.PeirceFunction(a, b);
                                break;
                            }
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek();
        }


        static public int Calculate(string input, BooleanFunctions booleanFunctions)
        {
            string output = ConvertToRPN(input);             //Перевод выражения в постфиксный вид
            int result = Counting(output, booleanFunctions); //Вычисление выражения в постфискной записи
            return result;                                   //Возврат результата
        }
    }
}
