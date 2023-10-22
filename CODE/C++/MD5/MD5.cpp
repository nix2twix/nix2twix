#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;
class graph
{
public:
    vector<int> edges;
    vector<int> vertexes;

    graph()
    {
        edges.resize(0);
        vertexes.resize(0);
    }

    graph(int edge_cnt, int vertex_cnt)
    {
        edges.resize(edge_cnt);
        vertexes.resize(vertex_cnt);
    }
};

int main()
{
    int n, t;
    cin >> n >> t;
    graph g(n,n);
    queue <int> q;
    return 0;
}
