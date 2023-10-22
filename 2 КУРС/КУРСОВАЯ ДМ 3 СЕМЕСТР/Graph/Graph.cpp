#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>
#include <time.h>
#include <iomanip>
#include <vector>
#include "Graph.h"
using namespace std;

#define N  5								//количество городов
#define RUNS 50							//число поколений муравьёв
#define alpha 1							//расчётная константа
#define beta 5							//расчётная константа
#define Q 1								//расчётная константа
float minW = FLT_MAX;						//поле памяти, хранящее 
//минимальный вес пути	
vector <vector <float>> path;
vector <vector <float>> feromon;				//массив значений феромонов
vector <float> temp;
vector <int> instance;						//текущий путь
vector <bool> visited;
vector <double> weights;
vector <vector <int>> paths; 					//все пути
vector <int> bestPath;						//наилучший путь


int Search(vector <float> temp, float r)
{
	for (int i = 0; i < N; i++)
	{
		if (temp[i] >= r)
			return i;
	}
	return 1;
}
vector <vector <float>> UpdateFeromon(vector <vector <float>> f, vector <int> instance)
{
	for (int k = 0; k < N; k++)
	{
		for (int i = 0; i < N; i++)
		{
			f[k][i] *= 0.95;
		}
	}

	for (int i = 0; i < N - 1; i++)
	{
		int a = instance[i];
		int b = instance[i + 1];
		f[a][b] += 0.2;
	}

	f[instance[N - 1]][instance[0]] += 0.2;
	return f;
}


float RoadLength(vector <vector <float>> path, vector <int> currentPath)
{
	float weight = 0;
	for (int i = 0; i < N - 1; i++)
	{
		weight += path[currentPath[i]][currentPath[i + 1]];
	}
	weight += path[currentPath[N - 1]][currentPath[0]];

	return weight;
}

vector <vector <float>> ReadMatrix(vector <vector <float>> path)
{
	ifstream input("input.txt");
	for (size_t i = 0; i < N; i++)				//чтение матрицы смежности
	{
		for (size_t j = 0; j < N; j++)
		{
			input >> path[i][j];
		}
	}
	input.close();
	return path;
}

void MakeFeromonMatrix(vector <vector <float>> feromonMatrix)
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)			//чтение матрицы феромонов
		{
			if (i == j)
				feromonMatrix[i][j] = 0.0;
		}
	}
	return;
}

void AntSolverRun()
{
	path.clear();						//обновление данных
	path.resize(N, vector<float>(N, FLT_MAX));
	feromon.clear();
	feromon.resize(N, vector<float>(N, 1));

	MakeFeromonMatrix(feromon);
	path = ReadMatrix(path);

	int sum;
	temp.clear(); temp.resize(N, 0);
	instance.clear(); instance.resize(N, 0);
	visited.clear(); visited.resize(N, false);

	int R = rand() % N;					//выбор первой вершины
	instance[0] = R;
	visited[R] = true;
	for (int k = 1; k < N; k++)
	{
		sum = 0;
		for (int i = 0; i < N; i++)			//расчет феромоновых путей

		{
			temp[i] = path[R][i] * feromon[R][i];
			sum += path[R][i];
		}

		for (int i = 0; i < N; i++)
		{
			temp[i] /= sum;
			if (i > 0)
				temp[i] += temp[i - 1];
		}

		while (true) 					//проход по всем вершинам

		{
			float r = ((float)rand() / (RAND_MAX));
			int next = Search(temp, r);

			if (!visited[next])			//если вершина не посещена
			{
				visited[next] = true;
				instance[k] = next;
				break;
			}

		}
	}

	feromon = UpdateFeromon(feromon, instance);		//обновление феромоновых 
	//следов
	float weight = RoadLength(path, instance);		//расчёт веса текущего пути

	if (weight < minW)						//отбор наикратчайшего пути
	{
		minW = weight;
		bestPath = instance;
	}
	return;
}

int main()
{
	setlocale(LC_ALL, "RUSSIAN");
	Graph graph;
	graph.ReadMatrix();

	int i = 0;
	do {
		AntSolverRun();
		i++;
	} while (i < RUNS);

	cout << "\n\n\t\t\t\tМинимальная длина пути: " << minW;
	printf("\n\n\t\t\t\tМаршрут: ");
	for (auto to : bestPath)
		cout << to + 1 << " --> ";
	cout << bestPath[0] + 1 << "\n";


	return 0;
}




/*#include <iostream>
#include "Graph.h"
#include <ctime>
using namespace std;

int minWeight = INT_MAX;
int lowerBound = 0;
vector <int> bestPath;
vector <int> currentPath;
vector <bool> visited;

void FinalPath(vector <int> currentPath)                //запись конечного маршрута
{
    bestPath.clear();
    for (int i = 0; i < currentPath.size(); i++)
        bestPath.push_back(currentPath[i]);
        bestPath.push_back(currentPath[0]);
    return;
}

int FirstMin(vector <vector <int>> matrix, int k)       //поиск первого подходящего ребра,
{                                                       //ведущего в вершину k
    int min = INT_MAX;
    for (int i = 0; i < matrix.size(); i++)
        if (matrix[k][i] < min && k != i)
            min = matrix[k][i];
    return min;
}
int SecondMin(vector <vector <int>> matrix, int k) //поиск второго подходящего ребра
{                                                  //ведущего в вершину k
    int first = INT_MAX, second = INT_MAX;
    for (int i = 0; i < matrix.size(); i++)
    {

        if (k != i && matrix[k][i] <= first)
        {
            second = first;
            first = matrix[k][i];
        }
        if (k != i && matrix[k][i] <= second
            && matrix[k][i] != first)
            second = matrix[k][i];
    }
    return second;
}

int Solver(vector <vector <int>> matrix, 		  //функция для поиска пути
    int currentBound, int currentWeight,
    int level, vector <int> currentPath)
{
    if (level == matrix.size())                    //текущий уровень дерева решений
    {                                              //достиг ранга матрицы смежности
        if (matrix[currentPath[level - 1]][currentPath[0]] != 0)
        {
            int currentRes = currentWeight +
                matrix[currentPath[level - 1]][currentPath[0]];

            if (currentRes < minWeight)
            {
                FinalPath(currentPath);
                minWeight = currentRes;
            }
        }
        return minWeight;
    }

    for (int i = 0; i < matrix.size(); i++)         //ветвление не закончено
    {
        if (matrix[currentPath[level - 1]][i] != 0  //вершина не посещена
            && visited[i] == false)
        {
            int temp = currentBound;                //запомнить текущую границу
            currentWeight += matrix[currentPath[level - 1]][i];
            //вычисление текущего веса пути
            if (level == 1)
                currentBound -= ((FirstMin(matrix, currentPath[level - 1]) +
                    FirstMin(matrix, i)) / 2);
            else
                currentBound -= ((SecondMin(matrix, currentPath[level - 1]) +
                    FirstMin(matrix, i)) / 2);

            if (currentBound + currentWeight
                < minWeight) 				//если текущее ветвление выгодно
            {                              	      //продолжить путь из него
                currentPath[level] = i;
                visited[i] = true;
                Solver(matrix, currentBound, currentWeight, level + 1,
                    currentPath);
            }

            currentWeight -= matrix[currentPath[level - 1]][i];
            currentBound = temp;
            visited.clear();
            visited.resize(matrix.size(), false);        //вернуться назад
            for (int j = 0; j <= level - 1; j++)
                visited[currentPath[j]] = true;
        }
    }
}

void BranchAndBoundSolver(vector <vector <int>> matrix)
{
    minWeight = INT_MAX;                      //сброс минимального веса пути
    lowerBound = 0;                           //обнуление нижней границы
    currentPath.resize(matrix[0].size(), -1); //массив для хранения текущего пути
    visited.resize(matrix[0].size(), false);  //массив для отметки пройденных вершин
    int min;
    for (int i = 0; i < matrix.size(); i++)   //вычисление нижней границы
    {
        min = INT_MAX;
        for (int j = 0; j < matrix[i].size(); j++)
        {
            if (matrix[i][j] < min && matrix[i][j] != 0) min = matrix[i][j];
        }
        lowerBound += min;
    }
    visited[0] = true;
    currentPath[0] = 0;

    Solver(matrix, lowerBound, 0, 1, currentPath); //рекурсивный поиск пути
    return;
}
int main()
{

    setlocale(LC_ALL, "RUSSIAN");
    Graph graph;
    graph.ReadMatrix();
    vector <vector <int>> matrix = graph.MakeMatrixFromList();
    unsigned int start_time = clock(); // начальное время
    BranchAndBoundSolver(matrix);

    printf("Минимальная длина пути: %d\n", minWeight);
    printf("Путь: ");
    for (int i = 0; i < graph.nodeCount; i++)
        printf("%d ", bestPath[i]);

    unsigned int end_time = clock(); // конечное время
    unsigned int search_time = end_time - start_time; // искомое время
    cout << "\ntime: " << search_time;
    return 0;
}
*/