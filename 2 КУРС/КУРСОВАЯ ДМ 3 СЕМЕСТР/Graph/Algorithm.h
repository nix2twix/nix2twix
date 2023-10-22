#pragma once
//Algorithm.h
#include <string>
#include <vector>
using namespace std;
class Algorithm
{
public:
	string name = "Algorithm";					//название алгоритма
	std::vector<vector<int>> matrix;		    //матрица смежности

	Algorithm();
	Algorithm(vector<vector<int>>);
	Algorithm(char*);

	bool LoadData(vector<vector<int>>);

	virtual void Run();					//метод для запуска алгоритма

protected:
	virtual bool validateData();		//метод для проверки значений в матрице
};