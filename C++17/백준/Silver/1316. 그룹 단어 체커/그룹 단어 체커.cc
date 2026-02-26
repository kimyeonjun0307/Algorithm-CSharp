#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    int cnt =0;
    int A;
    string B;
    char front;
    cin>>A;

    for(int i = 0;i<A; i++)
    {
        string result = "";
        bool ok = true;  

        cin>>B;
        if(B.size()==1)
        {
            cnt ++;
            continue;
        }

        front = B[0];

        for(int j = 1; j<B.size(); j++)
        {
            if(front == B[j])
            {
                front = B[j];
            }
            else
            {   
                if(result.find(B[j]) != std::string::npos)
                {
                    ok = false;  
                    break;
                }
                result.push_back(front);
                front = B[j];
            }
        }

        if(ok) cnt++;   
    }

    cout<<cnt<<"\n";
}