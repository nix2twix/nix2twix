#include <iostream>
#include <cstdlib>
#include <ctime>  
#include <fstream>
#include <vector>
#include <random>

void Randomizer() 
{
    std::ofstream inputFile("input.txt");

    std::random_device rd;
    std::mt19937 gen(rd());
    std::uniform_real_distribution<double> dis(0.0, 1.0);


    int numPairs = 10;

    for (int i = 0; i < numPairs; ++i) 
    {
        double R = dis(gen);
        double G = dis(gen);
        inputFile << R * 5 << " " << G * 3 << "\n";
    }
    inputFile.close();
}

bool isInsideRectangle(double x, double y) 
{
    return (x >= 0.0 && x <= 5.0 && y >= 0.0 && y <= 3.0);
}

bool isInsideHexagon(double x, double y) 
{
    return (
        (y >= 0.5 * x) && (y <= x) && (x >= 0) && (x <= 2)
        || (y >= -x+3) && (y <= 0.5*x+1) && (x >= 2) && (x <= 3)
        || (y >= 0) && (y <= 0.5 * x + 1) && (x >= 3) && (x <= 4)
        || (y >= x - 4) && (y <= -2*x+11) && (x >= 4) && (x <= 5)
        );
}

int main(void) 
{
    Randomizer();
    std::ifstream inputFile("input.txt");
    std::vector<std::pair<double, double>> points;
    double x, y;
    int ctrY = 54, ctrTotal = 120;

    while (inputFile >> x >> y) 
    {
        points.emplace_back(x, y);
    }

    inputFile.close();

    for (const auto& point : points) 
    {
        if (isInsideHexagon(point.first, point.second))
        {
            ctrY++;
            std::cout << "yes\n";
        }

        ctrTotal++;
        std::cout << (((double)ctrY * 15) / ctrTotal) << "\n";
    }

    return EXIT_SUCCESS;
}
