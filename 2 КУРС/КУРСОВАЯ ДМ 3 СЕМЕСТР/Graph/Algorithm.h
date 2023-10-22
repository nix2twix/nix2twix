#pragma once
//Algorithm.h
#include <string>
#include <vector>
using namespace std;
class Algorithm
{
public:
	string name = "Algorithm";					//�������� ���������
	std::vector<vector<int>> matrix;		    //������� ���������

	Algorithm();
	Algorithm(vector<vector<int>>);
	Algorithm(char*);

	bool LoadData(vector<vector<int>>);

	virtual void Run();					//����� ��� ������� ���������

protected:
	virtual bool validateData();		//����� ��� �������� �������� � �������
};