
#include <iostream>
using namespace std;


int main()
{
    int A;
    cin>>A;
    if (A > 89)
    {
        cout<<"A"<<endl;
    }
    else if (90>A&&A> 79)
    {
        cout << "B" << endl;
    }
    else if (80>A && A >69)
    {
        cout << "C" << endl;
    }
    else if (70>A && A >59)
    {
        cout << "D" << endl;
    }
    else
    {
        cout<<"F"<<endl;
    }
}
