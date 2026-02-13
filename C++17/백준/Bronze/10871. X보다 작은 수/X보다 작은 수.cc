#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A,B,C;
    cin>>A>>B;
    vector<int> v;
    for(int i = 0; i<A; i++)
    {
        cin>>C;
        if(C<B)
        {
            v.push_back(C);

        }
    }
    for (int X: v)
    {
        cout<<X<<" ";
    }
}