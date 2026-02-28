#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    
    int A,B,C;
    cin>>A>>B;
    vector<vector<int>> arr(A, vector<int>(B));
    vector<vector<int>> arr2(A, vector<int>(B));
    for(int i = 0; i<A; i++)
    {
        for(int j = 0; j<B; j++)
        {
            cin>>arr[i][j];
        }
        
    }
   
     for(int i = 0; i<A; i++)
    {
        for(int j = 0; j<B; j++)
        {
            cin>>C;
            arr[i][j] += C;
        }
        
    }
     for(int i = 0; i<A; i++)
    {
        for(int j = 0; j<B; j++)
        {
            cout<<arr[i][j]<<" ";
        }
        cout<<"\n";
    }
    
}