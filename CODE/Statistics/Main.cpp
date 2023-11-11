

/*
#include <iostream>
#include <fstream>
#include <vector>
#include <random>
#include <string>

int main()
{
    std::ifstream file("input.txt"); // замените "filename.txt" на имя вашего файла
    std::vector<int> numbers;

   std::string line;
   int count = 0;
        while (getline(file, line))
        {
            for (int i = 2; i < line.length(); i++)
            {
                if (line[i] != '.' && line[i] != ' '
                    && line[i] != '0')
                {
                    int digit = line[i] - '0';
                    numbers.push_back(digit);
                }
            }
        }
        file.close();
        int pairCount = 0;
        int tripleCount = 0;

        for (int i = 0; i < numbers.size(); i++)
        {
            if (numbers[i] == 9)
                count++;
            if (i > 0 && numbers[i] == numbers[i - 1] && numbers[i] == 9)
            {
                pairCount++;
                if (i > 2 && numbers[i] == numbers[i - 2]
                    && numbers[i] == numbers[i - 1]
                    && numbers[i] == 9)
                {
                    tripleCount++;
                }
            }
        }

        std::cout << "Number of ones: " << count << std::endl;
        std::cout << "Number of pairs: " << pairCount << std::endl;
        std::cout << "Number of triples: " << tripleCount << std::endl;

}

*/
#include <iostream>
#include <fstream>
#include <vector>
#include <random>
const double e = 1e-10;
int main() 
{
    std::ifstream inputFile("input.txt");
    if (!inputFile.is_open()) 
    {
        std::cout << "Failed to open the file." << std::endl;
        return EXIT_FAILURE;
    }

    std::vector<double> numbers;
    double num;
    int ctr1 = 0;
    int ctr2 = 0;
    int ctr3 = 0;
    int ctr4 = 0;
    int ctr5 = 0;
    int ctr6 = 0;
    int ctr7 = 0;
    int ctr8 = 0;
    int ctr9 = 0;
    int ctr10 = 0;


    while (inputFile >> num) 
    {
        numbers.push_back(num);
        if (0 < num && num < 0.1)
            ctr1++;
        if (0.1 < num && num < 0.2)
            ctr2++;
        if (0.2 < num && num < 0.3)
            ctr3++;
        if (0.3 < num && num < 0.4)
            ctr4++;
        if (0.4 < num && num < 0.5)
            ctr5++;
        if (0.5 < num && num < 0.6)
            ctr6++;
        if (0.6 < num && num < 0.7)
            ctr7++;
        if (0.7 < num && num < 0.8)
            ctr8++;
        if (0.8 < num && num < 0.9)
            ctr9++;
        if (0.9 < num && num < 1)
            ctr10++;

    }

    inputFile.close();

    std::cout << ctr1 << "\n"
        << ctr2 << "\n"
        << ctr3 << "\n"
        << ctr4 << "\n"
        << ctr5 << "\n"
        << ctr6 << "\n"
        << ctr7 << "\n"
        << ctr8 << "\n"
        << ctr9 << "\n"
        << ctr10 << "\n";

    return EXIT_SUCCESS;
}
