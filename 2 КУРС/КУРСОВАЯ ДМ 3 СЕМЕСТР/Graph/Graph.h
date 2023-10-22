#include <vector>
#include <fstream>
#include <iostream>
#include <stdlib.h>
#include <iomanip>
#include <set>
#include <algorithm>
#include <string>
using namespace std;

class Graph //G = (X, V)
{
public:
	int nodeCount = 0; //количество вершин
	int edgeCount = 0; //количество рёбер
	vector <pair<pair<int, int>, int>> edges;

	Graph()
	{
		nodeCount = 0;
		edgeCount = 0;
		edges.resize(0);
	};

	Graph(int n, int m)
	{
		nodeCount = n;
		edgeCount = m;
		edges.resize(m+1);
	} //конструктор

	Graph& operator=(const Graph& A)
	{
		edgeCount = A.edgeCount;
		nodeCount = A.nodeCount;
		edges = A.edges;
		return *this;
	}

	void ReadMatrix();

	vector <vector <int>> MatrixToVector();

	void ReadListEdgesFromFile();

	void ReadListEdgesFromConsole();

	void PrintEdges();

	void PrintMatrix();

	vector <vector <int>> MakeMatrixFromList();

	vector <vector <float>> MakeFloatMatrixFromList();

	bool IsGamilton()
	{
		vector <int> degreeList = this->CountVertexDegree();
		return count(degreeList.begin(), degreeList.end(), 1) == 0;
	}

	vector <int> CountVertexDegree()
	{
		vector <vector <int>> matrix = this->MatrixToVector();
		vector <int> degreeList(nodeCount, 0);
		for (int i = 0; i < nodeCount; i++)
		{
			degreeList[i] = nodeCount - count(matrix[i].begin(), matrix[i].end(), 0);
		}
		return degreeList;
	}

	~Graph(){};

};

void PrintMatrix(vector <vector <int>> matrix, string diagonalSymbol)
{
	cout << "\n";
	for (int i = 0; i < matrix.size(); i++)
	{
		cout << "\t\t\t\t\t\t";
		for (int j = 0; j < matrix[i].size(); j++)
		{
			if (i != j)
				printf("%*d", 4, matrix[i][j]);
			else printf("%*s", 4, diagonalSymbol.c_str());
		} std::cout << "\n";
	}
	return;
}

void PrintMatrix(vector <vector <int>> matrix)
{
	cout << "\n\n";
	for (int i = 0; i < matrix.size(); i++)
	{
		cout << "\t\t\t\t\t\t";
		for (int j = 0; j < matrix[i].size(); j++)
		{
			if (i != j)
				printf("%*d", 4, matrix[i][j]);
			else printf("%*d", 4, -1);
		} std::cout << "\n";
	}
	return;
}

void PrintCuttedMatrix(vector <vector <int>> matrix, int row, int column)
{
	cout << "\n\n";
	for (int i = 0; i < matrix.size(); i++)
	{
		cout << "\t\t\t\t\t\t";
		for (int j = 0; j < matrix[i].size(); j++)
		{
			if (i != j && i != row && j != column)
				printf("%*d", 4, matrix[i][j]);
			if (i == j && i != row && j != column) 
				printf("%*s", 4, "inf");
		} std::cout << "\n";
	}
	return;
}

void Graph::PrintMatrix()
{
	system("cls");
	vector <vector <int>> matrix(nodeCount, vector<int>(nodeCount, 0));
	matrix = this->MatrixToVector();
	cout << "\n\t\t\t\tМатрица смежности:\n\n";
	for (int i = 0; i < this->nodeCount; i++)
	{
		cout << "\t\t\t\t\t\t";
		for (int j = 0; j < this->nodeCount; j++)
		{
			cout << matrix[i][j] << " ";
		}
		cout << "\n";
	}
	return;
}

void Graph::PrintEdges()
{
	system("cls");
	int i = 0;
	cout << "\n";
	cout << "\n\t\t\t\tСписок рёбер:\n";
	for (auto to : this->edges)
	{
		i++;
		cout << "\t\t\t\tРебро " << i << ". " << "(" << to.first.first + 1
			<< ", " << to.first.second + 1 << ")" << " с весом " << to.second
			<< "\n";
	}
}

void Graph::ReadMatrix()
{
	ifstream input("input.txt");
	int n, m = 0, a;
	input >> n;
	vector <vector <int>> matrix(n, vector<int>(n, 0));
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			input >> a;
			if (a == 1) m++;
			matrix[i][j] = a;
		}
	}

	this->nodeCount = n;
	this->edgeCount = m / 2;
	this->edges.clear();

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (matrix[i][j] != 0)
			{
				pair <pair<int, int>, int> vertexWithWeight;
				vertexWithWeight = make_pair(make_pair(i + 1, j + 1), matrix[i][j]);
				this->edges.push_back(vertexWithWeight);
			}
		}
	}
	sort(this->edges.begin(), this->edges.end());
	input.close();
	system("cls");
	cout << "\n\n\t\t\t\t!!!! Матрица смежности успешно считана!\n\n";
	return;
}

void Graph::ReadListEdgesFromFile()
{
	ifstream input("input.txt");
	int n, m;
	input >> n;
	input >> m;
	this->edges.clear();
	for (int i = 0; i < m; i++)
	{
		int a, b, weight;
		input >> a >> b >> weight;
		pair <pair<int, int>, int> vertexWithWeight = make_pair(make_pair(a, b), weight);
		edges.push_back(vertexWithWeight);
	}
	input.close();
	system("cls");
	if (!this->edges.empty()) cout << "\n\n\t\t\t\t!!!! Список рёбер успешно считан!\n\n";
	return;
}

void Graph::ReadListEdgesFromConsole()
{
	int n, m;
	cout << "\n";
	cout << "\n\t\t\t\tВведите число вершин: "; cin >> n;
	cout << "\n\t\t\t\tВведите число рёбер: "; cin >> m;
	this->edges.clear();
	cout << "\n\t\t\t\tВведите список рёбер:\n";
	for (int i = 0; i < m; i++)
	{
		int a, b;
		int weight;
		cout << "\t\t\t\tРебро " << i + 1 << ". ";  cin >> a >> b;
		cout << "\t\t\t\tЕго вес: "; cin >> weight;
		pair <pair<int, int>, int> vertexWithWeight = make_pair(make_pair(a, b), weight);
		edges.push_back(vertexWithWeight);
	}
	return;
}

vector <vector <int>> Graph::MatrixToVector()
{
	int inf = INT_MAX;                    //значение, принимаемое за бесконечность
	vector <vector <int>> matrix(nodeCount, vector <int>(nodeCount, 0));
	int i, j;
	for (auto to : edges)
	{
		i = to.first.first - 1;
		j = to.first.second - 1;
		matrix[i][j] = to.second;
	}
	for (int i = 0; i < nodeCount; i++)
	{
		for (int j = 0; j < nodeCount; j++)
		{
			if (i == j) matrix[i][j] = inf;
		}
	}
	return matrix;
};

vector <vector <int>> Graph::MakeMatrixFromList()
{
	vector <vector <int>> matrix(this->nodeCount, vector<int>(this->nodeCount, 0));
	for (int i = 0; i < this->edges.size(); i++)
	{
		matrix[this->edges[i].first.first - 1][this->edges[i].first.second - 1] = this->edges[i].second;
	}
	return matrix;
}
