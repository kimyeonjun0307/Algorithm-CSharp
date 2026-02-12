
#include <iostream>
using namespace std;


int main()
{
    int A,B;
    cin>>A>>B;
    if ((B - 45) < 0)
    {   
        if (A == 0)
        {
            cout<<23<<' '<<B+15<<endl;
        }
        else
        {
            cout << (A - 1) << ' ' << B + 15 << endl;
        }
        
    }
    else
    {
        cout<<A<<' '<<B-45<<endl;
    }
    return 0;
}
