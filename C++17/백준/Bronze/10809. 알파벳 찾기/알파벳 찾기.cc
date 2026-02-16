#include <bits/stdc++.h>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    string s;
    cin>>s;
    vector<int> result(26,-1);
    vector<char> alpha;
    for(char c = 'a'; c<='z'; c++)
    {
        alpha.push_back(c);
    }
    
    for(int j = s.size()-1; j>=0; j--)
    {   
        for(int i = 0; i<26; i++)
        {
            if(s[j] == alpha[i]  )
            {
                
                result[i] = j;
            }
            
        }
    }
    for(int x: result)
    {
        cout<<x<<" ";
    }
}