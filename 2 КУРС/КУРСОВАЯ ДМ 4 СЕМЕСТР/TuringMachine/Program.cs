using System;
using System.Collections.Generic;
using System.IO;

// Структура для хранения инструкций машины Тьюринга
struct Instruction
{
    public char writeSymbol;
    public char moveDirection;
    public int nextState;
}

class Program
{
    // Вывод текущего состояния ленты
    static void PrintTape(List<char> tape)
    {
        Console.Write("Current tape: ");
        foreach (char symbol in tape)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter input word: ");
        string inputWord = Console.ReadLine();

        List<char> tape = new List<char>();
        foreach (char symbol in inputWord)
        {
            tape.Add(symbol);
        }

        string alphabet;
        int numberOfStates;
        int startState;
        int haltState;
        Dictionary<(int, char), Instruction> instructions = new Dictionary<(int, char), Instruction>();

        // Чтение входных данных из файла input.txt
        using (StreamReader inputFile = 
            new StreamReader(@"D:\\WORK\\2 КУРС\\КУРСОВАЯ ДМ 4 СЕМЕСТР\\TuringMachine\\input.txt"))
        {
            alphabet = inputFile.ReadLine();
            string inputLine = inputFile.ReadLine();
            string[] inputValues = inputLine.Split(' ');
            numberOfStates = int.Parse(inputValues[0]);
            startState = int.Parse(inputValues[1]);
            haltState = int.Parse(inputValues[2]);


            // Чтение инструкций из файла input.txt и сохранение их в таблицу инструкций
            while ((inputLine = inputFile.ReadLine()) != null)
            {
                inputValues = inputLine.Split(' ');
                int state = int.Parse(inputValues[0]);
                char symbol = char.Parse(inputValues[1]);
                Instruction instr = new Instruction
                {
                    writeSymbol = char.Parse(inputValues[2]),
                    moveDirection = char.Parse(inputValues[3]),
                    nextState = int.Parse(inputValues[4])
                };
                instructions[(state, symbol)] = instr;
            }
        }

        // Инициализация начального состояния машины Тьюринга
        int currentState = startState;
        int headPosition = 0;

        // Цикл эмуляции работы машины Тьюринга
        while (currentState != haltState)
        {
            char currentSymbol = tape[headPosition];
            Instruction instr = instructions[(currentState, currentSymbol)];
            tape[headPosition] = instr.writeSymbol;

            if (instr.moveDirection == 'L')
            {
                if (headPosition == 0)
                {
                        tape.Insert(0, alphabet[0]);
                }
                else
                {
                    headPosition--;
                }
            }
            else if (instr.moveDirection == 'R')
            {
                headPosition++;
                if (headPosition == tape.Count)
                {
                    tape.Add(alphabet[0]);
                }
            }
            PrintTape(tape);
            currentState = instr.nextState;
        }

        // Вывод результата работы машины Тьюринга на экран
        Console.Write("Result: ");
        foreach (char symbol in tape)
        {
            if (symbol != '_') Console.Write(symbol);
        }
        Console.WriteLine();
    }
}