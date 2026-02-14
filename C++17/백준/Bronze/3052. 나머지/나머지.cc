#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A;
    vector<int> v;
    for (int i=0; i<10; i++)
    {
        cin>>A;
        v.push_back(A%42);
    }
    set<int> s(v.begin(),v.end());
    cout<<s.size()<<"\n";

}