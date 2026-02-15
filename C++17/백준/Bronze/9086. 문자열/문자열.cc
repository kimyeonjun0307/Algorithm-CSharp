#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A;
    cin>>A;
    string s;

    for( int i = 0; i<A; i++)
    {
        cin>>s;
        cout<<s[0]<<s[s.size()-1]<<"\n";// s.front()<<s.back() 가능
    }
    
}