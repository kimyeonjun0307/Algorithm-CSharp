
#include <iostream>
using namespace std;


int main()
{
    int A,B,C;
    cin>>A>>B>>C;
    A= A+(C/60);
    B= B+(C%60);
    if ((B / 60) > 0)
    {
        A= A+ (B/60);
        B= B%60;
    }
    A=A%24;
    cout<<A<<' '<<B<<endl;
    
    return 0;
}
