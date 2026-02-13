#include <bits/stdc++.h>
using namespace std;

int main()
 {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A,B;    
    cin>>A;
    vector<int> v(A);
    for (int i = 0; i<A; i++)
    {
        cin>>v[i];
    }
    cin>>B;    
    cout<<count(v.begin(),v.end(),B);
    
    return 0;
}