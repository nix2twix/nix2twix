#pragma once
#include <armadillo>
#include<iostream>
using namespace arma;
using namespace std;

extern const int city_size;
extern int m;
extern float alpha;
extern float beta;
extern float rho;
extern float Q;
extern int iter;
extern int iter_max;
extern int temp[100];
extern mat Tau;
extern imat Table;
extern imat Route_best;
extern mat Length_best;
extern mat Length_ave;
extern mat D;
extern imat citys;
extern mat Eta;
extern imat start; / *Стартовый город каждого муравья * /
extern imat citys_index;
extern mat Length;
extern mat Delta_Tau;

void shuffle(int r[]);
void Init();
double mean(mat);
int find_index(mat, double s); #pragma once
