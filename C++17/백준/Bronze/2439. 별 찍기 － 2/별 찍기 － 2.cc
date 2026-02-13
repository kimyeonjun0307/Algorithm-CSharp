#include <bits/stdc++.h>
using namespace std;

int main()
 {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int A;
    cin>>A;
    for (int i = 1; i<=A ; i++)
    {
        for(int j = A; j>0; j--)
        {
            if(i>=j)
            {
                cout<<"*";
            }
            else
            {
                cout<<" ";
            }
        }
        cout<<"\n";
    }


    return 0;
}