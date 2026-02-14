#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A;
    double B;
    cin>>A;
    vector<double> v;
    double sum = 0;

    for(int i = 0; i<A; i++)
    {   
        cin>>B;
        v.push_back(B);
    }
    auto it = max_element(v.begin(),v.end());
    for(int x= 0; x<v.size(); x++)
    {
        sum+=(v[x]/ *it)*100;
    }
    if( *it == 0)
    {
        cout<<0<<"\n";
    }
    else
    {
        
        cout<<fixed<<setprecision(2)<<(sum/A)<<"\n";
    }
   
}