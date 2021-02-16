#include<iostream>
#include "Solution.h"

using namespace std;

int main()
{

    string test_strings[5] {
        "11106",
        "205678",
        "035542",
        "915167",
        "111111"
    };



    Solution sln;

    //Test strings
    for (size_t i = 0; i < 5; i++)
    {
        int result = sln.numDecodings(test_strings[i]);

        cout << "Test " << i << " :String " << test_strings[i] << " result" << endl;
    }
    
}